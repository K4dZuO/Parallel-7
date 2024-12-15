using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace ATPRV_PZ7
{
    public partial class WebCrawlerForm : Form
    {
        private readonly HttpClient _httpClient;
        private readonly ConcurrentDictionary<string, CrawledData> _tree;
        private readonly ConcurrentQueue<(string url, int depth)> _queue;
        private readonly ConcurrentDictionary<string, byte> _visited;
        private readonly ConcurrentBag<string> _images;
        private readonly List<DepthProcessingInfo> _processingInfo;

        public WebCrawlerForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _tree = new ConcurrentDictionary<string, CrawledData>();
            _queue = new ConcurrentQueue<(string url, int depth)>();
            _visited = new ConcurrentDictionary<string, byte>();
            _images = new ConcurrentBag<string>();
            _processingInfo = new List<DepthProcessingInfo>();
        }

        private void WebCrawlerForm_Load(object sender, EventArgs e)
        {

        }

        private async void buttonStartCrawl_Click(object sender, EventArgs e)
        {
            string rootUrl = textBoxRootUrl.Text;
            int maxDepth = int.Parse(textBoxDepth.Text);

            await StartCrawling(rootUrl, maxDepth);

            dataGridViewResults.DataSource = GetTreeData();

            // Отображение информации о глубинах и дереве в DataGridView
            dataGridViewInfo.DataSource = _processingInfo;

            var rootNode = BuildTree(rootUrl);
            PrintTree(rootNode);
        }

        private async Task StartCrawling(string rootUrl, int maxDepth)
        {
            _queue.Enqueue((rootUrl, 0));
            var sw = new Stopwatch();

            int depth = 0;

            while (_queue.Count > 0)
            {
                sw.Restart();
                int initialQueueCount = _queue.Count;

                var tasks = new List<Task>();

                while (initialQueueCount-- > 0)
                {
                    if (_queue.TryDequeue(out var item))
                    {
                        tasks.Add(ProcessUrl(item.url, item.depth, maxDepth));
                    }
                }

                await Task.WhenAll(tasks);
                sw.Stop();

                long elapsedMilliseconds = sw.ElapsedMilliseconds;

                // Обновление лейбла с информацией о текущей глубине
                UpdateDepthLabel(depth, elapsedMilliseconds);

                // Вывод информации о дереве после обработки глубины
                var treeData = GetTreeData();
                int treeHeight = treeData.Max(d => d.Depth);
                int nodeCount = treeData.Count;
                var leafNodes = treeData.Where(d => d.Links.Count == 0).Take(5).Select(d => d.Url).ToList();

                var depthInfo = new DepthProcessingInfo
                {
                    Depth = treeData.Max(d => d.Depth),
                    ProcessingTime = elapsedMilliseconds,
                    TreeHeight = treeHeight,
                    NodeCount = nodeCount,
                    LeafNodes = string.Join(", ", leafNodes)
                };

                _processingInfo.Add(depthInfo);

                Console.WriteLine($"Tree height: {treeHeight}");
                Console.WriteLine($"Number of nodes: {nodeCount}");
                Console.WriteLine("Leaf nodes (sample):");
                leafNodes.ForEach(leaf => Console.WriteLine(leaf));

                depth++;
            }
        }

        // Метод для обновления текста лейбла
        private void UpdateDepthLabel(int depth, long elapsedMilliseconds)
        {
            // Предположим, что у тебя есть лейблы с именами labelDepth0, labelDepth1, и так далее.
            var labelName = $"labelDepth{depth}";
            var label = Controls.Find(labelName, true).FirstOrDefault() as Label;

            if (label != null)
            {
                label.Text = $"Depth {depth}: {elapsedMilliseconds} ms";
            }
        }


        private async Task ProcessUrl(string url, int depth, int maxDepth)
        {
            if (depth >= maxDepth || !_visited.TryAdd(url, 0))
            {
                return;
            }

            try
            {
                var response = await _httpClient.GetStringAsync(url);
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(response);

                var links = doc.DocumentNode.SelectNodes("//a[@href]")?.Select(a => a.GetAttributeValue("href", null)).Where(u => u != null).ToList() ?? new List<string>();
                var images = doc.DocumentNode.SelectNodes("//img[@src]")?.Select(img => img.GetAttributeValue("src", null)).Where(src => src != null).ToList() ?? new List<string>();

                Console.WriteLine($"Processing URL: {url}, Depth: {depth}, Links found: {links.Count}, Images found: {images.Count}");

                foreach (var img in images)
                {
                    _images.Add(img);
                }

                _tree[url] = new CrawledData
                {
                    Url = url,
                    Links = links,
                    Images = images,
                    Depth = depth
                };

                foreach (var link in links)
                {
                    if (Uri.TryCreate(new Uri(url), link, out var absoluteUri) && absoluteUri.Host == new Uri(url).Host)
                    {
                        _queue.Enqueue((absoluteUri.ToString(), depth + 1));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {url}: {ex.Message}");
            }
        }

        private List<CrawledData> GetTreeData()
        {
            return _tree.Values.ToList();
        }
        private TreeNode BuildTree(string rootUrl)
        {
            if (!_tree.ContainsKey(rootUrl))
                return null;

            var rootNode = new TreeNode { Url = rootUrl };

            foreach (var childUrl in _tree[rootUrl].Links)
            {
                if (_tree.ContainsKey(childUrl)) // Проверяем, есть ли информация о дочерней странице
                {
                    var childNode = BuildTree(childUrl); // Рекурсивно строим дерево
                    if (childNode != null)
                        rootNode.Children.Add(childNode);
                }
            }

            return rootNode;
        }

        private void PrintTree(TreeNode node, int level = 0)
        {
            if (node == null) return;

            // Выводим текущий узел с отступом
            Console.WriteLine(new string('-', level * 2) + node.Url);

            // Рекурсивно выводим дочерние узлы
            foreach (var child in node.Children)
            {
                PrintTree(child, level + 1);
            }
        }

    }

    public class CrawledData
    {
        public string Url { get; set; }
        public List<string> Links { get; set; }
        public List<string> Images { get; set; }
        public int Depth { get; set; }
    }

    public class DepthProcessingInfo
    {
        public int Depth { get; set; }
        public long ProcessingTime { get; set; }
        public int TreeHeight { get; set; }
        public int NodeCount { get; set; }
        public string LeafNodes { get; set; }
    }
    public class TreeNode
    {
        public string Url { get; set; }
        public List<TreeNode> Children { get; set; } = new List<TreeNode>();
    }


}

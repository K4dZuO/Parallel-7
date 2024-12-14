using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace ATPRV_PZ7
{
    public partial class MapReduceForm : Form
    {
        OpenFileDialog loadFileDialog;
        List<string> fileNames = new List<string>();
        List<string> fileContents = new List<string>();
        List<string> wordsToCount = new List<string>();
        List<int> wordsCount = new List<int>();

        public MapReduceForm()
        {
            InitializeComponent();
            InitOpenFileDialog();
        }

        private void InitOpenFileDialog()
        {
            loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            loadFileDialog.Title = "Выберите несколько файлов";
            loadFileDialog.Multiselect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNames.Clear();
                fileContents.Clear();

                foreach (string file in loadFileDialog.FileNames)
                {
                    fileNames.Add(file);
                    fileContents.Add(System.IO.File.ReadAllText(file));
                }
                textBox1.Text = string.Join(", ", fileNames);
                startButton.Enabled = true;
                MessageBox.Show("Файлы успешно загружены");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 && textBox3.Text.Length == 0 && textBox4.Text.Length == 0)
            {
                MessageBox.Show("Введите слова для поиска!");
            }
            else
            {
                // parallel processing
                Task.Run(() =>
                {
                    getWordsToCount();
                    Start();
                });
            }
        }

        private void getWordsToCount()
        {
            // Инициализируем список
            wordsToCount = new List<string>();

            // Считываем слова из всех текстовых полей
            var textBoxes = new[] { textBox2, textBox3, textBox4 }; // Список текстбоксов

            foreach (var textBox in textBoxes)
            {
                var words = textBox.Text
                    .Split(new char[] { '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries); // убрал ' ' 
                wordsToCount.AddRange(words); // Добавляем слова в общий список
            }
            

            // Убираем дубликаты (если нужно)
            wordsToCount = wordsToCount.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }

        private void Start()
        {
            var time = MeasureTime(() =>
            {
                wordsCount = wordsToCount.AsParallel()
                .Select(word => fileContents.AsParallel()
                   .Sum(content => Regex.Matches(content, $@"\b{Regex.Escape(word)}\b", RegexOptions.IgnoreCase).Count))
                       .ToList();
            });

            listBox1.Invoke(new Action(() => listBox1.Items.Clear()));
            listBox1.Invoke(new Action(() => listBox1.Items.Add($"Время выполнения: {time} ms")));

            for (int i = 0; i < wordsToCount.Count; i++)
            {
                var item = $"{wordsToCount[i]} - {wordsCount[i]}";
                listBox1.Invoke(new Action(() => listBox1.Items.Add(item)));
            }
        }
        private long MeasureTime(Action action)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            action.Invoke();
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        
    }
}

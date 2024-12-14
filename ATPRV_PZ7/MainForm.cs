namespace ATPRV_PZ7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        MapReduceForm mapReduce;
        private void mapReduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mapReduce == null)
            {
                mapReduce = new MapReduceForm();
                mapReduce.MdiParent = this;
                mapReduce.FormClosed += new FormClosedEventHandler(mapReduce_FormClosed);
                mapReduce.Show();
            }
            else
            {
                mapReduce.Activate();
            }
        }

        private void mapReduce_FormClosed(object? sender, FormClosedEventArgs e)
        {
            mapReduce = null;
        }

        WebCrawlerForm webCrawler;
        private void webCrawlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webCrawler == null)
            {
                webCrawler = new WebCrawlerForm();
                webCrawler.MdiParent = this;
                webCrawler.FormClosed += new FormClosedEventHandler(webCrawler_FormClosed);
                webCrawler.Show();
            }
            else
            {
                webCrawler.Activate();
            }

        }

        private void webCrawler_FormClosed(Object? sender, FormClosedEventArgs e)
        {
            webCrawler = null;
        }

        private EmployeeForm employeeForm;
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeeForm == null)
            {
                employeeForm = new EmployeeForm();
                employeeForm.MdiParent = this;
                employeeForm.FormClosed += (s, args) => employeeForm = null;
                employeeForm.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }
    }
}

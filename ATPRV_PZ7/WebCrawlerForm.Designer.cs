namespace ATPRV_PZ7
{
    partial class WebCrawlerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonStartCrawl; // Объявляем кнопку здесь
        private System.Windows.Forms.TextBox textBoxRootUrl;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridView dataGridViewInfo; // Новый DataGridView для отображения информации о дереве

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelDepth3 = new Label();
            labelDepth2 = new Label();
            labelDepth1 = new Label();
            labelDepth0 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonStartCrawl = new Button();
            textBoxRootUrl = new TextBox();
            textBoxDepth = new TextBox();
            dataGridViewResults = new DataGridView();
            dataGridViewInfo = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 479);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelDepth3);
            tabPage1.Controls.Add(labelDepth2);
            tabPage1.Controls.Add(labelDepth1);
            tabPage1.Controls.Add(labelDepth0);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonStartCrawl);
            tabPage1.Controls.Add(textBoxRootUrl);
            tabPage1.Controls.Add(textBoxDepth);
            tabPage1.Controls.Add(dataGridViewResults);
            tabPage1.Controls.Add(dataGridViewInfo);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Crawler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelDepth3
            // 
            labelDepth3.AutoSize = true;
            labelDepth3.Location = new Point(585, 81);
            labelDepth3.Name = "labelDepth3";
            labelDepth3.Size = new Size(50, 20);
            labelDepth3.TabIndex = 10;
            labelDepth3.Text = "label3";
            // 
            // labelDepth2
            // 
            labelDepth2.AutoSize = true;
            labelDepth2.Location = new Point(585, 46);
            labelDepth2.Name = "labelDepth2";
            labelDepth2.Size = new Size(50, 20);
            labelDepth2.TabIndex = 9;
            labelDepth2.Text = "label3";
            // 
            // labelDepth1
            // 
            labelDepth1.AutoSize = true;
            labelDepth1.Location = new Point(359, 81);
            labelDepth1.Name = "labelDepth1";
            labelDepth1.Size = new Size(50, 20);
            labelDepth1.TabIndex = 8;
            labelDepth1.Text = "label3";
            // 
            // labelDepth0
            // 
            labelDepth0.AutoSize = true;
            labelDepth0.Location = new Point(359, 46);
            labelDepth0.Name = "labelDepth0";
            labelDepth0.Size = new Size(50, 20);
            labelDepth0.TabIndex = 7;
            labelDepth0.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 46);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 6;
            label2.Text = "Глубина поиска (от 0)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 5;
            label1.Text = "Источник (url)";
            // 
            // buttonStartCrawl
            // 
            buttonStartCrawl.Location = new Point(8, 81);
            buttonStartCrawl.Name = "buttonStartCrawl";
            buttonStartCrawl.Size = new Size(87, 33);
            buttonStartCrawl.TabIndex = 2;
            buttonStartCrawl.Text = "Start Crawling";
            buttonStartCrawl.UseVisualStyleBackColor = true;
            buttonStartCrawl.Click += buttonStartCrawl_Click;
            // 
            // textBoxRootUrl
            // 
            textBoxRootUrl.Location = new Point(186, 6);
            textBoxRootUrl.Name = "textBoxRootUrl";
            textBoxRootUrl.Size = new Size(598, 27);
            textBoxRootUrl.TabIndex = 0;
            textBoxRootUrl.Text = "https://www.example.com";
            // 
            // textBoxDepth
            // 
            textBoxDepth.Location = new Point(186, 39);
            textBoxDepth.Name = "textBoxDepth";
            textBoxDepth.Size = new Size(100, 27);
            textBoxDepth.TabIndex = 1;
            textBoxDepth.Text = "3";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(8, 120);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 51;
            dataGridViewResults.Size = new Size(836, 150);
            dataGridViewResults.TabIndex = 3;
            // 
            // dataGridViewInfo
            // 
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(8, 288);
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.RowHeadersWidth = 51;
            dataGridViewInfo.Size = new Size(836, 150);
            dataGridViewInfo.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(852, 446);
            tabPage2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(852, 446);
            tabPage3.TabIndex = 2;
            // 
            // WebCrawlerForm
            // 
            ClientSize = new Size(860, 479);
            Controls.Add(tabControl1);
            Name = "WebCrawlerForm";
            Text = "Web Crawler";
            Load += WebCrawlerForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ResumeLayout(false);
        }

        private Label label2;
        private Label label1;
        private Label labelDepth0;
        private Label labelDepth3;
        private Label labelDepth2;
        private Label labelDepth1;
    }
}


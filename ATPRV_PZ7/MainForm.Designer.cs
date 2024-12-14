namespace ATPRV_PZ7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            задачиToolStripMenuItem = new ToolStripMenuItem();
            mapReduceToolStripMenuItem = new ToolStripMenuItem();
            webCrawlerToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { задачиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // задачиToolStripMenuItem
            // 
            задачиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mapReduceToolStripMenuItem, webCrawlerToolStripMenuItem, employeeToolStripMenuItem });
            задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            задачиToolStripMenuItem.Size = new Size(72, 24);
            задачиToolStripMenuItem.Text = "Задачи";
            // 
            // mapReduceToolStripMenuItem
            // 
            mapReduceToolStripMenuItem.Name = "mapReduceToolStripMenuItem";
            mapReduceToolStripMenuItem.Size = new Size(224, 26);
            mapReduceToolStripMenuItem.Text = "MapReduce";
            mapReduceToolStripMenuItem.Click += mapReduceToolStripMenuItem_Click;
            // 
            // webCrawlerToolStripMenuItem
            // 
            webCrawlerToolStripMenuItem.Name = "webCrawlerToolStripMenuItem";
            webCrawlerToolStripMenuItem.Size = new Size(224, 26);
            webCrawlerToolStripMenuItem.Text = "Web Crawler";
            webCrawlerToolStripMenuItem.Click += webCrawlerToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(224, 26);
            employeeToolStripMenuItem.Text = "Employees";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Основное окно";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        
        

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem задачиToolStripMenuItem;
        private ToolStripMenuItem mapReduceToolStripMenuItem;
        private ToolStripMenuItem webCrawlerToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;

    }
}

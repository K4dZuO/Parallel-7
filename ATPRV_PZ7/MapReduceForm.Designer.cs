namespace ATPRV_PZ7
{
    partial class MapReduceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Enabled = false;
            startButton.Location = new Point(548, 382);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 0;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 24);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 2;
            button1.Text = "Открыть файлы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(540, 27);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(26, 127);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(398, 284);
            listBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(457, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 127);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 6;
            label1.Text = "Слова для поиска через пробел";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(457, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(457, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(280, 27);
            textBox4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 170);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 9;
            label2.Text = "Слово №1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 232);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 10;
            label3.Text = "Слово №2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 292);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 11;
            label4.Text = "Слово №3";
            // 
            // MapReduceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(startButton);
            Name = "MapReduceForm";
            Text = "Задача 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
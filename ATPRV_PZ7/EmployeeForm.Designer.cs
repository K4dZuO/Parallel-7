namespace ATPRV_PZ7
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvQueryResults;
        private System.Windows.Forms.Button btnGenerateData;
        private System.Windows.Forms.TextBox txtFioFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Button btnConsistOf;
        private System.Windows.Forms.Button btnFilterByDate;
        private System.Windows.Forms.Button btnSortByAvgSum;
        private System.Windows.Forms.Label lblLinqTime;
        private System.Windows.Forms.Label lblPlinqTime;
        private System.Windows.Forms.Button btnFilterByStart;
        private System.Windows.Forms.Button btnFilterByDateBefore;


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
            dgvEmployees = new DataGridView();
            dgvOrders = new DataGridView();
            dgvQueryResults = new DataGridView();
            btnGenerateData = new Button();
            txtFioFilter = new TextBox();
            dtpFilterDate = new DateTimePicker();
            btnConsistOf = new Button();
            btnFilterByDate = new Button();
            btnSortByAvgSum = new Button();
            lblLinqTime = new Label();
            lblPlinqTime = new Label();
            btnFilterByStart = new Button();
            btnFilterByDateBefore = new Button();
            label1 = new Label();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueryResults).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeight = 29;
            dgvEmployees.Location = new Point(10, 10);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(608, 200);
            dgvEmployees.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeight = 29;
            dgvOrders.Location = new Point(10, 220);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(608, 200);
            dgvOrders.TabIndex = 2;
            // 
            // dgvQueryResults
            // 
            dgvQueryResults.ColumnHeadersHeight = 29;
            dgvQueryResults.Location = new Point(10, 430);
            dgvQueryResults.Name = "dgvQueryResults";
            dgvQueryResults.RowHeadersWidth = 51;
            dgvQueryResults.Size = new Size(608, 200);
            dgvQueryResults.TabIndex = 3;
            // 
            // btnGenerateData
            // 
            btnGenerateData.Location = new Point(641, 20);
            btnGenerateData.Name = "btnGenerateData";
            btnGenerateData.Size = new Size(135, 49);
            btnGenerateData.TabIndex = 1;
            btnGenerateData.Text = "Сгенерировать данные";
            btnGenerateData.Click += BtnGenerateData_Click;
            // 
            // txtFioFilter
            // 
            txtFioFilter.Location = new Point(702, 97);
            txtFioFilter.Name = "txtFioFilter";
            txtFioFilter.Size = new Size(235, 27);
            txtFioFilter.TabIndex = 4;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(641, 229);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(120, 27);
            dtpFilterDate.TabIndex = 7;
            // 
            // btnConsistOf
            // 
            btnConsistOf.Location = new Point(641, 130);
            btnConsistOf.Name = "btnConsistOf";
            btnConsistOf.Size = new Size(120, 51);
            btnConsistOf.TabIndex = 5;
            btnConsistOf.Text = "Содержит...";
            btnConsistOf.Click += BtnFilterByFIO_Click;
            // 
            // btnFilterByDate
            // 
            btnFilterByDate.Location = new Point(641, 262);
            btnFilterByDate.Name = "btnFilterByDate";
            btnFilterByDate.Size = new Size(120, 40);
            btnFilterByDate.TabIndex = 8;
            btnFilterByDate.Text = "Заказы до...";
            btnFilterByDate.Click += BtnFilterByDate_Click;
            // 
            // btnSortByAvgSum
            // 
            btnSortByAvgSum.Location = new Point(641, 352);
            btnSortByAvgSum.Name = "btnSortByAvgSum";
            btnSortByAvgSum.Size = new Size(120, 40);
            btnSortByAvgSum.TabIndex = 10;
            btnSortByAvgSum.Text = "Sort by Avg Order";
            btnSortByAvgSum.Click += BtnSortByAvgSum_Click;
            // 
            // lblLinqTime
            // 
            lblLinqTime.Location = new Point(641, 407);
            lblLinqTime.Name = "lblLinqTime";
            lblLinqTime.Size = new Size(120, 22);
            lblLinqTime.TabIndex = 11;
            lblLinqTime.Text = "LINQ Time:";
            // 
            // lblPlinqTime
            // 
            lblPlinqTime.Location = new Point(641, 437);
            lblPlinqTime.Name = "lblPlinqTime";
            lblPlinqTime.Size = new Size(120, 22);
            lblPlinqTime.TabIndex = 12;
            lblPlinqTime.Text = "PLINQ Time:";
            // 
            // btnFilterByStart
            // 
            btnFilterByStart.Location = new Point(767, 130);
            btnFilterByStart.Name = "btnFilterByStart";
            btnFilterByStart.Size = new Size(170, 51);
            btnFilterByStart.TabIndex = 6;
            btnFilterByStart.Text = "Начинается с ...";
            btnFilterByStart.Click += BtnFilterByStart_Click;
            // 
            // btnFilterByDateBefore
            // 
            btnFilterByDateBefore.Location = new Point(804, 262);
            btnFilterByDateBefore.Name = "btnFilterByDateBefore";
            btnFilterByDateBefore.Size = new Size(120, 40);
            btnFilterByDateBefore.TabIndex = 9;
            btnFilterByDateBefore.Text = "Заказы после...";
            btnFilterByDateBefore.Click += BtnFilterByDateBefore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, 100);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "Ввод:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(804, 37);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(15, 20);
            labelStatus.TabIndex = 14;
            labelStatus.Text = "_";
            // 
            // EmployeeForm
            // 
            ClientSize = new Size(990, 650);
            Controls.Add(labelStatus);
            Controls.Add(label1);
            Controls.Add(dgvEmployees);
            Controls.Add(btnGenerateData);
            Controls.Add(dgvOrders);
            Controls.Add(dgvQueryResults);
            Controls.Add(txtFioFilter);
            Controls.Add(btnConsistOf);
            Controls.Add(btnFilterByStart);
            Controls.Add(dtpFilterDate);
            Controls.Add(btnFilterByDate);
            Controls.Add(btnFilterByDateBefore);
            Controls.Add(btnSortByAvgSum);
            Controls.Add(lblLinqTime);
            Controls.Add(lblPlinqTime);
            Name = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueryResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label labelStatus;
    }
}

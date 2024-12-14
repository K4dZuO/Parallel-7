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
        private System.Windows.Forms.Button btnFilterByFIO;
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
            // Здесь инициализируем элементы интерфейса (DataGridView, TextBox, Button и т.д.)
            // Для примера приведу инициализацию DataGridView и одной кнопки.
            
            this.ClientSize = new System.Drawing.Size(725, 650);
            
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvQueryResults = new System.Windows.Forms.DataGridView();
            this.btnGenerateData = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvQueryResults = new System.Windows.Forms.DataGridView();
            this.btnGenerateData = new System.Windows.Forms.Button();
            this.txtFioFilter = new System.Windows.Forms.TextBox();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilterByFIO = new System.Windows.Forms.Button();
            this.btnFilterByDate = new System.Windows.Forms.Button();
            this.btnSortByAvgSum = new System.Windows.Forms.Button();
            this.lblLinqTime = new System.Windows.Forms.Label();
            this.lblPlinqTime = new System.Windows.Forms.Label();
            this.btnFilterByStart = new System.Windows.Forms.Button();
            this.btnFilterByDateBefore = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // DataGridView для сотрудников
            this.dgvEmployees.Location = new System.Drawing.Point(10, 10);
            this.dgvEmployees.Size = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.dgvEmployees);

            // Кнопка для генерации данных
            this.btnGenerateData.Location = new System.Drawing.Point(420, 10);
            this.btnGenerateData.Size = new System.Drawing.Size(120, 40);
            this.btnGenerateData.Text = "Generate Data";
            this.btnGenerateData.Click += BtnGenerateData_Click;
            this.Controls.Add(this.btnGenerateData);
            
            // DataGridView для заказов
            this.dgvOrders.Location = new System.Drawing.Point(10, 220);
            this.dgvOrders.Size = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.dgvOrders);

            // DataGridView для результатов запросов
            this.dgvQueryResults.Location = new System.Drawing.Point(10, 430);
            this.dgvQueryResults.Size = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.dgvQueryResults);
            
            // Поле ввода для фильтрации по ФИО
            this.txtFioFilter.Location = new System.Drawing.Point(420, 60);
            this.txtFioFilter.Size = new System.Drawing.Size(120, 22);
            this.Controls.Add(this.txtFioFilter);

            // Кнопка фильтрации по ФИО
            this.btnFilterByFIO.Location = new System.Drawing.Point(420, 90);
            this.btnFilterByFIO.Size = new System.Drawing.Size(120, 40);
            this.btnFilterByFIO.Text = "Filter by FIO";
            this.btnFilterByFIO.Click += BtnFilterByFIO_Click;
            this.Controls.Add(this.btnFilterByFIO);
            
            // Кнопка фильтрации по началу ФИО
            this.btnFilterByStart.Location = new System.Drawing.Point(550, 90); // Расположение
            this.btnFilterByStart.Size = new System.Drawing.Size(170, 40); // Размер
            this.btnFilterByStart.Text = "Filter by StartsWith";
            this.btnFilterByStart.Click += BtnFilterByStart_Click; // Подключение обработчика
            this.Controls.Add(this.btnFilterByStart);

            // Календарь для фильтрации по дате
            this.dtpFilterDate.Location = new System.Drawing.Point(420, 138);
            this.dtpFilterDate.Size = new System.Drawing.Size(120, 22);
            this.Controls.Add(this.dtpFilterDate);

            // Кнопка фильтрации по дате
            this.btnFilterByDate.Location = new System.Drawing.Point(420, 170);
            this.btnFilterByDate.Size = new System.Drawing.Size(120, 40);
            this.btnFilterByDate.Text = "Filter by Date";
            this.btnFilterByDate.Click += BtnFilterByDate_Click;
            this.Controls.Add(this.btnFilterByDate);
            
            // Кнопка фильтрации по дате до
            this.btnFilterByDateBefore.Location = new System.Drawing.Point(577, 170); // Пример расположения
            this.btnFilterByDateBefore.Size = new System.Drawing.Size(120, 40);
            this.btnFilterByDateBefore.Text = "Filter Date ≤";
            this.btnFilterByDateBefore.Click += new System.EventHandler(this.BtnFilterByDateBefore_Click);
            this.Controls.Add(this.btnFilterByDateBefore);

            // Кнопка сортировки по средней сумме заказа
            this.btnSortByAvgSum.Location = new System.Drawing.Point(420, 220);
            this.btnSortByAvgSum.Size = new System.Drawing.Size(120, 40);
            this.btnSortByAvgSum.Text = "Sort by Avg Order";
            this.btnSortByAvgSum.Click += BtnSortByAvgSum_Click;
            this.Controls.Add(this.btnSortByAvgSum);

            // Метки для времени выполнения
            this.lblLinqTime.Location = new System.Drawing.Point(420, 270);
            this.lblLinqTime.Size = new System.Drawing.Size(120, 22);
            this.lblLinqTime.Text = "LINQ Time:";
            this.Controls.Add(this.lblLinqTime);

            this.lblPlinqTime.Location = new System.Drawing.Point(420, 300);
            this.lblPlinqTime.Size = new System.Drawing.Size(120, 22);
            this.lblPlinqTime.Text = "PLINQ Time:";
            this.Controls.Add(this.lblPlinqTime);
            
            this.ResumeLayout(false);
        }
    }
}

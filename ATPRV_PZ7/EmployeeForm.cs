using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATPRV_PZ7.Models;
using ATPRV_PZ7.Services;

namespace ATPRV_PZ7
{
    public partial class EmployeeForm : Form
    {
        private readonly DataGenerationService _dataService;
        private List<Employee> _employees;

        public EmployeeForm()
        {
            InitializeComponent();
            _dataService = new DataGenerationService();
        }

        private void BtnGenerateData_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                // Генерация данных
                _employees = _dataService.GenerateEmployees(10000);

                // Вывод первых 100 сотрудников
                dgvEmployees.Invoke(() => dgvEmployees.DataSource = _employees.Take(100).ToList());

                // Вывод первых 500 заказов
                dgvOrders.Invoke(() => dgvOrders.DataSource = _employees.SelectMany(emp => emp.Orders).Take(500).ToList());
            });

        }

        private void BtnFilterByFIO_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string filter = txtFioFilter.Text;

                var linqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .Where(emp => emp.FullName.Contains(filter))
                        .SelectMany(emp => emp.Orders)
                        .ToList();

                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                
                lblLinqTime.Invoke(() => lblLinqTime.Text = $"LINQ: {linqTime} ms");

                var plinqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .AsParallel()
                        .Where(emp => emp.FullName.Contains(filter))
                        .SelectMany(emp => emp.Orders)
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                lblPlinqTime.Invoke(() => lblPlinqTime.Text = $"PLINQ: {plinqTime} ms");
            });
        }
        private void BtnFilterByStart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string filter = txtFioFilter.Text;

                // LINQ
                var linqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .Where(emp => emp.FullName.StartsWith(filter)) // Фильтрация сотрудников
                        .SelectMany(emp => emp.Orders) // Объединение заказов
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result); // Отображение результатов
                });

                lblLinqTime.Invoke(() => lblLinqTime.Text = $"LINQ: {linqTime} ms");

                // PLINQ
                var plinqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .AsParallel()
                        .Where(emp => emp.FullName.StartsWith(filter)) // Параллельная фильтрация
                        .SelectMany(emp => emp.Orders)
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                lblPlinqTime.Invoke(() => lblPlinqTime.Text = $"PLINQ: {plinqTime} ms");
            });
        }

        private long MeasureTime(Action action)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            action.Invoke();
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        
        private void BtnFilterByDate_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                DateTime selectedDate = dtpFilterDate.Value;

                var linqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .SelectMany(emp => emp.Orders)
                        .Where(order => order.OrderDate >= selectedDate)
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                lblLinqTime.Invoke(() => lblLinqTime.Text = $"LINQ: {linqTime} ms");

                var plinqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .AsParallel()
                        .SelectMany(emp => emp.Orders)
                        .Where(order => order.OrderDate >= selectedDate)
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                lblPlinqTime.Invoke(() => lblPlinqTime.Text = $"PLINQ: {plinqTime} ms");
            });
        }
        private void BtnFilterByDateBefore_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                DateTime selectedDate = dtpFilterDate.Value;

                // LINQ
                var linqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .SelectMany(emp => emp.Orders) // Объединение всех заказов сотрудников
                        .Where(order => order.OrderDate <= selectedDate) // Фильтрация заказов
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result); // Отображение результата
                });

                lblLinqTime.Invoke(() => lblLinqTime.Text = $"LINQ: {linqTime} ms");

                // PLINQ
                var plinqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .AsParallel()
                        .SelectMany(emp => emp.Orders)
                        .Where(order => order.OrderDate <= selectedDate) // Параллельная фильтрация
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result); // Отображение результата
                });

                lblPlinqTime.Invoke(() => lblPlinqTime.Text = $"PLINQ: {plinqTime} ms");
            });
        }
        
        private void BtnSortByAvgSum_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var linqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .OrderBy(emp => emp.Orders.Average(order => order.OrderSum))
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                lblLinqTime.Invoke(() => lblLinqTime.Text = $"LINQ: {linqTime} ms");

                var plinqTime = MeasureTime(() =>
                {
                    var result = _employees
                        .AsParallel()
                        .OrderBy(emp => emp.Orders.Average(order => order.OrderSum))
                        .ToList();
                    dgvQueryResults.Invoke(() => dgvQueryResults.DataSource = result);
                });

                lblPlinqTime.Invoke(() => lblPlinqTime.Text = $"PLINQ: {plinqTime} ms");
            });
        }

    }
}
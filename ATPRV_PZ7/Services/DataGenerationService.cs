using System;
using System.Collections.Generic;
using ATPRV_PZ7.Models;
using Bogus;

namespace ATPRV_PZ7.Services
{
    public class DataGenerationService
    {
        private int _employeeIdCounter = 1; // Счетчик для генерации уникальных ID сотрудников
        private int _orderIdCounter = 1;    // Счетчик для генерации уникальных ID заказов

        public List<Employee> GenerateEmployees(int count)
        {
            var faker = new Faker("ru");
            var employees = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                var employee = new Employee
                {
                    Id = _employeeIdCounter++, // Уникальный ID сотрудника
                    FullName = faker.Name.FullName(),
                    Orders = GenerateOrders(faker.Random.Int(50, 100))
                };

                foreach (var order in employee.Orders)
                {
                    order.EmployeeId = employee.Id; // Установка связи с сотрудником
                }

                employees.Add(employee);
            }

            return employees;
        }

        private List<Order> GenerateOrders(int count)
        {
            var faker = new Faker("ru");
            var orders = new List<Order>();

            for (int i = 0; i < count; i++)
            {
                orders.Add(new Order
                {
                    Id = _orderIdCounter++, // Уникальный ID заказа
                    OrderDate = faker.Date.Past(1),
                    OrderSum = Math.Round(faker.Random.Decimal(10, 1000), 2)
                });
            }
            return orders;
        }
    }
}

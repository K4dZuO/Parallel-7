using System;
using System.Collections.Generic;
using ATPRV_PZ7.Models;
using Bogus;

namespace ATPRV_PZ7.Services
{
    public class DataGenerationService
    {
        public List<Employee> GenerateEmployees(int count)
        {
            var faker = new Faker("en");
            var employees = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                var employee = new Employee
                {
                    FullName = faker.Name.FullName(),
                    Orders = GenerateOrders(faker.Random.Int(50, 100)) // Случайное количество заказов
                };

                employees.Add(employee);
                Console.WriteLine(employee);
            }

            return employees;
        }

        private List<Order> GenerateOrders(int count)
        {
            var faker = new Faker("en");
            var orders = new List<Order>();

            for (int i = 0; i < count; i++)
            {
                orders.Add(new Order
                {
                    OrderDate = faker.Date.Past(1), // Дата за последний год
                    OrderSum = faker.Random.Decimal(10, 1000) // Сумма от 10 до 1000
                });
            }

            return orders;
        }
    }
}
using System.Collections.Generic;

namespace ATPRV_PZ7.Models
{
    public class Employee
    {
        public string FullName { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
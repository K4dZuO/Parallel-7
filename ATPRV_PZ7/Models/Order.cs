namespace ATPRV_PZ7.Models
{
    public class Order
    {
        public int Id { get; set; } // Уникальный идентификатор заказа
        public DateTime OrderDate { get; set; }
        public decimal OrderSum { get; set; }
        public int EmployeeId { get; set; } // Идентификатор сотрудника-владельца заказа
    }
}
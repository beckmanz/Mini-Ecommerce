namespace Mini_Ecommerce.Models.Entity;

public class PaymentModel
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
    public DateTime PaymentDate { get; set; }
    public OrderModel Order { get; set; }
}
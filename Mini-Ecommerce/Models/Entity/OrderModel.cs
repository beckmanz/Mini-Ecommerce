using Mini_Ecommerce.Models.Enums;

namespace Mini_Ecommerce.Models.Entity;

public class OrderModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public Status Status { get; set; }
    public decimal TotalAmount { get; set; }
    public UserModel User { get; set; }
    public ICollection<OrderItemModel> OrderItems { get; set; }
    public PaymentModel Payment { get; set; }
}
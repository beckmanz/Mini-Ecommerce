namespace Mini_Ecommerce.Models.Entity;

public class CartModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public UserModel User { get; set; }
    public virtual ICollection<CartItemModel> CartItems { get; set; }
}
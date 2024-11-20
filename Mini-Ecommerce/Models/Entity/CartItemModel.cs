namespace Mini_Ecommerce.Models.Entity;

public class CartItemModel
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public CartModel Cart { get; set; }
    public ProductModel Product { get; set; }
}
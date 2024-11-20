namespace Mini_Ecommerce.Models.Entity;

public class InventoryModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Stock { get; set; }
    public int LowStockAlert { get; set; }
    public DateTime LastUpdated { get; set; }
    public ProductModel Product { get; set; }
}
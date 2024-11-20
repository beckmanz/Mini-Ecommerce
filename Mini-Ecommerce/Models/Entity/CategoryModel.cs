namespace Mini_Ecommerce.Models.Entity;

public class CategoryModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductModel> Products { get; set; }
}
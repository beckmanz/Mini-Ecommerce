﻿namespace Mini_Ecommerce.Models.Entity;

public class ProductModel
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public CategoryModel Category { get; set; }
    public InventoryModel Inventory { get; set; }
}
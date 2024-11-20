﻿namespace Mini_Ecommerce.Models.Entity;

public class OrderItemModel
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public OrderModel Order { get; set; }
    public ProductModel Product { get; set; }
}
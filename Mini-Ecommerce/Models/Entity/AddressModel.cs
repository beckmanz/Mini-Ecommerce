namespace Mini_Ecommerce.Models.Entity;

public class AddressModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Street { get; set; }
    public int NumberHouse { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public bool IsDefault { get; set; }
}
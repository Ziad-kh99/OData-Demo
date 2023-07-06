namespace ODataOrdersAPI.Models;



public class Product
{
    public int Id { get; set;}
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public ICollection<Order> Orders { get; set; }
}
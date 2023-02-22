namespace ECommerceAPI.Domain.Entities;
public class Product : BaseAuditableEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public ICollection<Order> Orders { get; set;}

}

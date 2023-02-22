namespace ECommerceAPI.Domain.Entities;
public class Order : BaseAuditableEntity
{
    public string Address { get; set; } 
    public string Description { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }

    public ICollection<Product> Products { get; set; }

}

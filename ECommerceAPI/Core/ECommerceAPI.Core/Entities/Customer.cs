namespace ECommerceAPI.Domain.Entities;
public class Customer : BaseAuditableEntity
{
    public string Name { get; set; }    
    public ICollection<Order> Orders { get; set; }
}

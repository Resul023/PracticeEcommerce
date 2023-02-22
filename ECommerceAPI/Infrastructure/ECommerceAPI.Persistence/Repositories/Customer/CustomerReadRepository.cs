namespace ECommerceAPI.Persistence.Repositories;
public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}

namespace ECommerceAPI.Persistence.Repositories;
public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}

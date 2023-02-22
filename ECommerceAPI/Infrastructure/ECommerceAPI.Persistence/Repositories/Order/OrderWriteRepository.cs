namespace ECommerceAPI.Persistence.Repositories;
public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}

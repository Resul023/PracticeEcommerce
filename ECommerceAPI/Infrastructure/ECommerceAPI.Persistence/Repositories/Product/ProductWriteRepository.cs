namespace ECommerceAPI.Persistence.Repositories;
public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}

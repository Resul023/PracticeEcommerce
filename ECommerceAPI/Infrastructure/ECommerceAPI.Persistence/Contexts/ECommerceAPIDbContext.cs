namespace ECommerceAPI.Persistence.Contexts;
public class ECommerceAPIDbContext:DbContext
{
	IHttpContextAccessor contextAccessor;
    public ECommerceAPIDbContext(DbContextOptions options, IHttpContextAccessor contextAccessor) : base(options)
    {
        this.contextAccessor = contextAccessor;
    }
    public DbSet<Product> Products { get; set; }
	public DbSet<Order> Orders { get; set; }
	public DbSet<Customer> Customers { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ChangeTracker.Entries<BaseAuditableEntity>().ToList().ForEach(data =>
		{
            string ip = contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            if (ip == "::1")
            {
                ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[2].ToString();
            }

            if (data.State == EntityState.Added)
            {
                data.Entity.CreatedDate = DateTime.Now;
                data.Entity.CreatedBy = ip;
            }
            else if(data.State == EntityState.Modified)
            {
                data.Entity.LastModifiedTime = DateTime.Now;
                data.Entity.LastModifiedBy = ip;
            }
		});
        
        return await base.SaveChangesAsync(cancellationToken);
    }

}

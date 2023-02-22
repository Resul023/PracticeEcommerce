namespace ECommerceAPI.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<ECommerceAPIDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("local")));
        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

    }
}

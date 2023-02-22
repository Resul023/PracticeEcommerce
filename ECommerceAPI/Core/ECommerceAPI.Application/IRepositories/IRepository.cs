namespace ECommerceAPI.Application.IRepositories;
public interface IRepository<TEntity> where TEntity : BaseEntity
{
    DbSet<TEntity> Table { get; }
}

namespace ECommerceAPI.Application.IRepositories;
public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    Task<bool> AddAsync(TEntity model);
    Task<bool> AddRangeAsync(List<TEntity> models);
    bool Remove(TEntity model);
    bool RemoveRange(List<TEntity> models);
    Task<bool> RemoveById(string id);
    bool Update(TEntity model);
    Task<int> SaveAsync();
}

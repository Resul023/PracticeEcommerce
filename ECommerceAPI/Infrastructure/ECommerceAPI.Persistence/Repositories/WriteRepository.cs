
namespace ECommerceAPI.Persistence.Repositories;
public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ECommerceAPIDbContext _context;

    public WriteRepository(ECommerceAPIDbContext context)
    {
        this._context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<bool> AddAsync(TEntity model)
    {
        EntityEntry<TEntity> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<TEntity> models)
    {
        await Table.AddRangeAsync(models); return true;
    }

    public bool Remove(TEntity model)
    {
        EntityEntry<TEntity> entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;
    }

    public async Task<bool> RemoveById(string id)
    {
        TEntity model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        return Remove(model);
    }

    public bool RemoveRange(List<TEntity> models)
    {
        Table.RemoveRange(models); return true;
    }

    public bool Update(TEntity model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }
    public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();

    
}

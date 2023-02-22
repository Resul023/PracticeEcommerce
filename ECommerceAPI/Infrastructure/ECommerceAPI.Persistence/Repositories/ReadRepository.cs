namespace ECommerceAPI.Persistence.Repositories;
public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ECommerceAPIDbContext _context;

    public ReadRepository(ECommerceAPIDbContext context)
    {
        this._context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public IQueryable<TEntity> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public async Task<TEntity> GetByIdAsync(string id, bool tracking = true)
    {
        var query = Table.AsQueryable();  //Or you can get product with Find(id) if you use this you dont need marker designpattern
        if(!tracking)
            query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }


    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return await query.FirstOrDefaultAsync(expression);
    }

    public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query.Where(expression);
    }
}

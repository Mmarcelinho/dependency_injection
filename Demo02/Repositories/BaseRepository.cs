
namespace Demo02.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DataContext _context;

    public BaseRepository(DataContext context)
    {
            _context = context; 
    }

    public async Task<IList<T>> Lista()
    {
    return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> Criar(T Object)
    {
        await _context.Set<T>().AddAsync(Object);
        await _context.SaveChangesAsync();
        return Object;
    }
}

namespace Demo02.Repositories;

// Implementação genérica do repositório base que implementa a interface IBaseRepository
public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DataContext _context;

    public BaseRepository(DataContext context)
    {
            _context = context; 
    }

    // Método para listar todos os registros do tipo T
    public async Task<IList<T>> Lista()
    {
    return await _context.Set<T>().ToListAsync();
    }

    // Método para criar um novo registro do tipo T
    public async Task<T> Criar(T Object)
    {
        await _context.Set<T>().AddAsync(Object);
        await _context.SaveChangesAsync();
        return Object;
    }
}

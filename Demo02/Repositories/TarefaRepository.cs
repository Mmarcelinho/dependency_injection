namespace Demo02.Repositories;

public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
{
    private readonly DataContext _context;
    public TarefaRepository(DataContext context) : base(context)
    {
        _context = context; 
    }

    public async Task<IList<Tarefa>> TarefasConcluidas()
    {
        return await _context.Tarefa
        .Where(t => t.Concluida == true)
        .ToListAsync();
    }
}

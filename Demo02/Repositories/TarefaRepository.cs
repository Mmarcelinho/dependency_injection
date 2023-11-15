namespace Demo02.Repositories;

  // Implementação do repositório de tarefas que herda da classe BaseRepository passando o T(type) da classe e implementa a interface ITarefaRepository
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

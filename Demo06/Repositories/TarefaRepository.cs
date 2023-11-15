
namespace Demo06.Repositories;

public class TarefaRepository : ITarefaRepository
{
    private readonly DataContext _context;
    public TarefaRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<int> CriarTarefa(Tarefa tarefa)
    {
        await _context.Tarefa.AddAsync(tarefa);
        var result = await _context.SaveChangesAsync();
        return result;
    }

    public async Task<IList<Tarefa>> ListaTodasTarefas()
    {
        return await _context.Tarefa.ToListAsync();
    }

    public async Task<IList<Tarefa>> ListaTodasTarefasConcluidas()
    {
        return await _context.Tarefa.Where(t => t.Concluida == true).ToListAsync();
    }
}

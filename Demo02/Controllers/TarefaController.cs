namespace Demo02.Controllers;

[ApiController]
[Route("v1")]
public class TarefaController : ControllerBase
{
    private readonly IBaseRepository<Tarefa> _repository;
    private readonly ITarefaRepository _tarefaRepository;

    public TarefaController(IBaseRepository<Tarefa> repository, ITarefaRepository tarefaRepository)
    {
        _repository = repository;
        _tarefaRepository = tarefaRepository;
    }
    [HttpGet("/Tarefas")]
    public async Task<IList<Tarefa>> ListarTarefas()
    {
        return await _repository.Lista();
    }

    [HttpPost("/Criar/Tarefa")]
    public async Task<Tarefa> CriarTarefas(Tarefa tarefa)
    {
        return await _repository.Criar(tarefa);
    }

    [HttpGet("/TarefasConcluidas")]
    public async Task<IList<Tarefa>> ListarTarefasConcluidas()
    {
        return await _tarefaRepository.TarefasConcluidas();
    }
}

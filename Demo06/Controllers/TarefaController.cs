namespace Demo06.Controllers;

[ApiController]
[Route("v1")]
public class TarefaController : ControllerBase
{
    private readonly ITarefaRepository _tarefaRepository;
    
    public TarefaController(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    [HttpGet("Tarefa")]
    public async Task<ActionResult<IList<Tarefa>>> Get()
    {
        var result = await _tarefaRepository.ListaTodasTarefas();
        if (result is null)
            return NotFound();

        return Ok(result);
    }

    [HttpGet("Tarefa/TarefasConcluidas")]
    public async Task<ActionResult<IList<Tarefa>>> GetTarefasConcluidas()
    {
        var result = await _tarefaRepository.ListaTodasTarefasConcluidas();
        if (result is null)
            return NotFound();

        return Ok(result);
    }


    [HttpPost("Criar/Tarefa")]
    public async Task<IActionResult> CriarTarefa(TarefaInput model)
    {
        var tarefa = new Tarefa(model.Titulo,model.Concluida);
        var result = await _tarefaRepository.CriarTarefa(tarefa);
    return result > 0 ? StatusCode(StatusCodes.Status201Created):StatusCode(StatusCodes.Status500InternalServerError);
    }

 
}

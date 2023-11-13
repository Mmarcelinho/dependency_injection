namespace Demo02.Repositories.Interfaces;

    public interface ITarefaRepository : IBaseRepository<Tarefa> 
    {
     Task<IList<Tarefa>> TarefasConcluidas();
    }
    

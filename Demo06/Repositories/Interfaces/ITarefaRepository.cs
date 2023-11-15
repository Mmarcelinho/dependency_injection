namespace Demo06.Repositories.Interfaces;

    public interface ITarefaRepository
    {
        Task<IList<Tarefa>> ListaTodasTarefas();

        Task<int> CriarTarefa(Tarefa tarefa);

        Task<IList<Tarefa>> ListaTodasTarefasConcluidas();
    }

namespace Demo02.Repositories.Interfaces;

    public interface IBaseRepository<T> where T : class
    {
        Task<IList<T>> Lista();

        Task<T> Criar(T Object);
    }

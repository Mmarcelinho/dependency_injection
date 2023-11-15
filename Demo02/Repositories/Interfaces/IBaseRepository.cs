namespace Demo02.Repositories.Interfaces;

    // Interface genérica que define operações básicas para um repositório
    // Esta interface é parametrizada com o tipo T, indicando que as operações são para um tipo específico de entidade
    public interface IBaseRepository<T> where T : class
    {
        // Método para obter uma lista de todos os registros do tipo T
        Task<IList<T>> Lista();

        // Método para criar um novo registro do tipo T
        Task<T> Criar(T Object);
    }


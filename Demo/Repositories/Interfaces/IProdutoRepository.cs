namespace Demo.Repositories.Interfaces;

    public interface IProdutoRepository
    {
        Task<IList<Produto>> GetAllProducts();
    }

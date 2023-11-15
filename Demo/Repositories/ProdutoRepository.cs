namespace Demo.Repositories;

// Implementação do repositório de produtos que implementa a interface IProdutoRepository
public class ProdutoRepository : IProdutoRepository
{
    private readonly DataContext _context;

    public ProdutoRepository(DataContext context)
    {
        _context = context;
    }
    //Implementação do método da interface
    public async Task<IList<Produto>> GetAllProducts()
    {
        return await _context.Produto.ToListAsync();
    }
}

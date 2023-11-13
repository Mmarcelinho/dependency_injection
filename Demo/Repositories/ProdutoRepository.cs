namespace Demo.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly DataContext _context;

    public ProdutoRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<IList<Produto>> GetAllProducts()
    {
        return await _context.Produto.ToListAsync();
    }
}

#region Services 
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseInMemoryDatabase("Data");
});

// Registro do serviço de repositório de produtos no contêiner de injeção de dependência
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

var app = builder.Build();
#endregion

// Mapeamento da rota "/Produtos" para a operação GetAllProducts do IProdutoRepository
app.MapGet("/Produtos", (IProdutoRepository _produtoRepository) =>
{
    _produtoRepository.GetAllProducts();
});

app.Run();

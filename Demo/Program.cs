#region Services 
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseInMemoryDatabase("Data");
});

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

var app = builder.Build();
#endregion

app.MapGet("/Produtos", (IProdutoRepository _produtoRepository) =>
{
    _produtoRepository.GetAllProducts();
});

app.Run();

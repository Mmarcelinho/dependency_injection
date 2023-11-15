var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("Data"));
// builder.Services.AddScoped<ITarefaRepository,TarefaRepository>();

// Define o uso do Autofac como o provedor de serviços para a aplicação
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Configuração do contêiner Autofac para injeção de dependência
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Registro do serviço do contexto do EF Core
    containerBuilder.Register(x =>
    {
        // Configuração do contexto do EF Core para uso de um banco de dados em memória
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseInMemoryDatabase("data");
        
        // Retorna uma instância do contexto do EF Core configurada para banco de dados em memória
        return new DataContext(optionsBuilder.Options);
    }).InstancePerLifetimeScope(); // Define o tempo de vida da instância como LifetimeScope

    // Registro do tipo TarefaRepository que implementa ITarefaRepository
    containerBuilder.RegisterType<TarefaRepository>()
        .As<ITarefaRepository>() // Declara que TarefaRepository implementa ITarefaRepository
        .InstancePerLifetimeScope(); // Define o tempo de vida da instância como LifetimeScope
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

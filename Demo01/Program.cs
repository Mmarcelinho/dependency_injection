var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona serviços com diferentes escopos ao contêiner
// Transient: Uma nova instância a cada solicitação
builder.Services.AddTransient<IOperationTransient, Operation>(); 
// Scoped: Uma instância por escopo (normalmente, por solicitação HTTP)
builder.Services.AddScoped<IOperationScoped, Operation>();    
// Singleton: Uma única instância durante toda a vida da aplicação   
builder.Services.AddSingleton<IOperationSingleton, Operation>();  


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

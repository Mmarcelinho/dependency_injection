var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PagamentoBoleto>();
builder.Services.AddScoped<PagamentoCartao>();
builder.Services.AddScoped<PagamentoPix>();
builder.Services.AddTransient<Func<ServiceEnum, IPagamento>>(serviceProvider => key =>
{
    switch (key)
    {
        case ServiceEnum.Boleto: return serviceProvider.GetRequiredService<PagamentoBoleto>();
        case ServiceEnum.Cartao: return serviceProvider.GetRequiredService<PagamentoCartao>();
        case ServiceEnum.Pix: return serviceProvider.GetRequiredService<PagamentoPix>();
        default: return serviceProvider.GetRequiredService<PagamentoBoleto>();
    }

});

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

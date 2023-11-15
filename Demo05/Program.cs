var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registro das implementações concretas de IPagamento no contêiner
builder.Services.AddScoped<PagamentoBoleto>();
builder.Services.AddScoped<PagamentoCartao>();
builder.Services.AddScoped<PagamentoPix>();

// Registro da fábrica funcional para resolução dinâmica de IPagamento
builder.Services.AddTransient<Func<ServiceEnum, IPagamento>>(serviceProvider => key =>
{
    // Switch case para mapear ServiceEnum para a implementação correta de IPagamento
    switch (key)
    {
        case ServiceEnum.Boleto: return serviceProvider.GetRequiredService<PagamentoBoleto>();
        case ServiceEnum.Cartao: return serviceProvider.GetRequiredService<PagamentoCartao>();
        case ServiceEnum.Pix: return serviceProvider.GetRequiredService<PagamentoPix>();
        default: return serviceProvider.GetRequiredService<PagamentoBoleto>();
    }
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
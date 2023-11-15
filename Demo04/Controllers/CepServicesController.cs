namespace Demo04.Controllers;

    [Route("v1")]
    public class CepServicesController : Controller
    {
        // Provedor de serviços para obter instâncias de serviços por injeção de dependência
        private readonly IServiceProvider _serviceProvider;

        // Construtor que recebe o provedor de serviços por injeção de dependência
        public CepServicesController(IServiceProvider serviceProvider)
        {
           _serviceProvider = serviceProvider;
        }

    [HttpGet("/GetCep")]
    public Task<CepModel> GetCep(string cep)
    {
       // Obtém uma instância do serviço ICepService usando o provedor de serviços
       return _serviceProvider.GetRequiredService<ICepService>().GetCep(cep);
    }
    
}
namespace Demo04.Controllers;

    [Route("v1")]
    public class CepServicesController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public CepServicesController(IServiceProvider serviceProvider)
        {
           _serviceProvider = serviceProvider;
        }

    [HttpGet("/GetCep")]
    public Task<CepModel> GetCep(string cep)
    {
       return _serviceProvider.GetRequiredService<ICepService>().GetCep(cep);
    }
    
}
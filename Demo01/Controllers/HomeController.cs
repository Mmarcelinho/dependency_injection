namespace Demo01.Controllers;

    [ApiController]
    [Route("api/")]
    public class HomeController : ControllerBase
    {
        // Injeção de dependência das diferentes operações com escopos diferentes
        private readonly IOperationTransient _transientOperation1;
        private readonly IOperationTransient _transientOperation2;
        private readonly IOperationScoped _scopedOperation1;
        private readonly IOperationScoped _scopedOperation2;
        private readonly IOperationSingleton _singletonOperation1;
        private readonly IOperationSingleton _singletonOperation2;

        // Construtor que recebe as instâncias das operações por injeção de dependência
        public HomeController(
        IOperationTransient transientOperation1,
        IOperationTransient transientOperation2,
        IOperationScoped scopedOperation1,
        IOperationScoped scopedOperation2,
        IOperationSingleton singletonOperation1,
        IOperationSingleton singletonOperation2)
        {
            _transientOperation1 = transientOperation1;
            _transientOperation2 = transientOperation2;
            _scopedOperation1 = scopedOperation1;
            _scopedOperation2 = scopedOperation2;
            _singletonOperation1 = singletonOperation1;
            _singletonOperation2 = singletonOperation2;
        }

        
        // Rota GET para retornar informações sobre as operações
        [HttpGet]
        public String Get()
        {
            return $"Transient1: {_transientOperation1.OperationId} \n" +
                   $"Transient2: {_transientOperation2.OperationId} \n" +
                   $"Scoped1: {_scopedOperation1.OperationId} \n" +
                   $"Scoped2: {_scopedOperation2.OperationId} \n" +
                   $"Singleton1: {_singletonOperation1.OperationId} \n" +
                   $"Singleton2: {_singletonOperation2.OperationId} \n";
        }

    }


namespace Demo01.Services;

    public class Operation : IOperationTransient,
    IOperationScoped, 
    IOperationSingleton
    {
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString();
        }

        public string OperationId { get; }
    }

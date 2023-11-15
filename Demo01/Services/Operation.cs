namespace Demo01.Services;

     // Implementação da interface IOperation, que fornece um identificador único para operações
    public class Operation : IOperationTransient,
    IOperationScoped, 
    IOperationSingleton
    {
        // Construtor que gera um identificador único para cada instância
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString();
        }

        // Propriedade que retorna o identificador único da operação
        public string OperationId { get; }
    }

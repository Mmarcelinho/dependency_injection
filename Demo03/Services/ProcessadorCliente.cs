namespace Demo03.Services;

 public class ProcessadorCliente
    {
        //variável privada que armazena uma instância de uma classe que implementa a interface IProcessadorImagem
        private IProcessadorImagem? _processador;

        // Propriedade para obter ou definir o processador de imagem
        public IProcessadorImagem ProcessadorImagem
        {
            get
            {
                // Se o processador ainda não foi definido, usa o processador padrão
                if (_processador is null)
                    _processador = new ProcessadorPadrao();

                return _processador;
            }
            set
            {
                // Lança uma exceção se o valor passado for nulo
                if (value is null)
                    throw new ArgumentNullException(nameof(value));

                // Define o novo processador
                _processador = value;
            }
        }

        // Método que realiza o processamento usando o processador atual
        public void RealizarProcessamento()
        {
            Console.WriteLine("Realizando processamento:");
            ProcessadorImagem.Processar();
        }
    }

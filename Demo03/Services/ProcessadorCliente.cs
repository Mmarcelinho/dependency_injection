namespace Demo03.Services;

public class ProcessadorCliente
{
    private IProcessadorImagem? _processador;

    public IProcessadorImagem ProcessadorImagem
    {
        get
        {
            if (_processador is null)

                _processador = new ProcessadorPadrao();

            return _processador;
        }
        set
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

             _processador = value;   
        }
    }

      public void RealizarProcessamento()
    {
        Console.WriteLine("Realizando processamento:");
        ProcessadorImagem.Processar();
    }
}

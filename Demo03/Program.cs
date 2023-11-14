class Program
{
    static void Main()
    {
        var cliente = new ProcessadorCliente();

        cliente.RealizarProcessamento();

        var ProcessadorAvançado = new ProcessadorAvançado();
        cliente.ProcessadorImagem = ProcessadorAvançado;

        cliente.RealizarProcessamento();
    }
}
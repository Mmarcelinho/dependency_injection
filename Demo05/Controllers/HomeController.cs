namespace Demo05.Controllers;

[Route("v1")]
public class HomeController : Controller
{
    // A função que resolve dinamicamente a implementação de IPagamento com base no ServiceEnum
    private readonly Func<ServiceEnum, IPagamento> _service;

    // Construtor do controlador que recebe a função como parâmetro
    public HomeController(Func<ServiceEnum, IPagamento> service)
    {
        _service = service;
    }

    [HttpGet("Boleto")]
    public string GetPagamentoBoleto()
    {
        // Obtém a instância de IPagamento associada a ServiceEnum.Boleto e chama ConfirmacaoPagamento()
        var result = _service(ServiceEnum.Boleto);
        return result.ConfirmacaoPagamento();
    }

    [HttpGet("Cartao")]
    public string GetPagamentoCartao()
    {
        // Obtém a instância de IPagamento associada a ServiceEnum.Cartao e chama ConfirmacaoPagamento()
        var result = _service(ServiceEnum.Cartao);
        return result.ConfirmacaoPagamento();
    }

    [HttpGet("Pix")]
    public string GetPagamentoPix()
    {
        // Obtém a instância de IPagamento associada a ServiceEnum.Pix e chama ConfirmacaoPagamento()
        var result = _service(ServiceEnum.Pix);
        return result.ConfirmacaoPagamento();
    }
}
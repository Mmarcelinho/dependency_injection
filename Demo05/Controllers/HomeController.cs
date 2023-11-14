namespace Demo05.Controllers;

[Route("v1")]
public class HomeController : Controller
{
    private readonly Func<ServiceEnum, IPagamento> _service;

    public HomeController(Func<ServiceEnum, IPagamento> service)
    {
        _service = service;
    }

    [HttpGet("Boleto")]
    public string GetPagamentoBoleto()
    {
        var result = _service(ServiceEnum.Boleto);
        return result.ConfirmacaoPagamento();
    }

    [HttpGet("Cartao")]
    public string GetPagamentoCartao()
    {
        var result = _service(ServiceEnum.Cartao);
        return result.ConfirmacaoPagamento();
    }

    [HttpGet("Pix")]
    public string GetPagamentoPix()
    {
        var result = _service(ServiceEnum.Pix);
        return result.ConfirmacaoPagamento();
    }
}

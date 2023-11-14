namespace Demo05.Services;

public class PagamentoBoleto : IPagamento
{
    public string ConfirmacaoPagamento()
    {
        return $"Cod:{Guid.NewGuid()} - Pagamento via Boleto APROVADO - {DateTime.Now}";
    }
}

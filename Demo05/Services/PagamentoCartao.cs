namespace Demo05.Services;

public class PagamentoCartao : IPagamento
{
    public string ConfirmacaoPagamento()
    {
        return $"Cod:{Guid.NewGuid()} - Pagamento via Cartão APROVADO - {DateTime.Now}";
    }
}

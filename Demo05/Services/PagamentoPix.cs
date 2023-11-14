namespace Demo05.Services;

    public class PagamentoPix : IPagamento
    {
         public string ConfirmacaoPagamento()
    {
        return $"Cod:{Guid.NewGuid()} - Pagamento via Pix APROVADO - {DateTime.Now}";
    }
    }

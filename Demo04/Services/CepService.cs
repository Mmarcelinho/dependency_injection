namespace Demo04.Services;

    // Implementação do serviço ICepService que obtém informações de CEP usando uma API externa
    public class CepService : ICepService
    {
        // Método para obter informações de CEP assincronamente
        public async Task<CepModel> GetCep(string cep)
        {
            // Criação de uma instância do cliente HTTP
            var client = new HttpClient();

            // Realiza uma solicitação GET à API externa de CEP
            var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

            // Lê o conteúdo da resposta
            var content = await response.Content.ReadAsStringAsync();

            // Desserializa o conteúdo JSON em um objeto CepModel
            var cepResult = JsonSerializer.Deserialize<CepModel>(content);

            return cepResult;
        }
    }


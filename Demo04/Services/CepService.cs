namespace Demo04.Services;

public class CepService : ICepService
{
    public async Task<CepModel> GetCep(string cep)
    {
        var client = new HttpClient();

        var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

        var content = await response.Content.ReadAsStringAsync();

        var cepResult = JsonSerializer.Deserialize<CepModel>(content);

        return cepResult;
    }
}


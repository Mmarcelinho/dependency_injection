namespace Demo04.Services.Interface;

    public interface ICepService
    {
        Task<CepModel> GetCep(string cep);
    }

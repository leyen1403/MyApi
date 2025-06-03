using MyApi.Core.Models;

namespace MyApi.Infranstructure.Services
{
    public interface IJsonplaceholderHttpClientService
    {
        Task<List<Jsonplaceholder>> GetData();
    }
}
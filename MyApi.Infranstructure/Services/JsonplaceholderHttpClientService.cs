using MyApi.Core.Models;
using System.Net.Http.Json;

namespace MyApi.Infranstructure.Services
{
    public class JsonplaceholderHttpClientService : IJsonplaceholderHttpClientService
    {
        HttpClient _httpClient;

        public JsonplaceholderHttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Jsonplaceholder>> GetData()
        {
            return await _httpClient.GetFromJsonAsync<List<Jsonplaceholder>>("ChucVu");
        }
    }
}

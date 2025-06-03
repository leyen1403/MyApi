using MyApi.Core.Models;
using System.Net.Http.Json;

namespace MyApi.Infranstructure.Services
{
    public class JokeHttpClientService : IJokeHttpClientService
    {
        private readonly HttpClient httpClient;
        public JokeHttpClientService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Joke?> GetRandomJokeAsync()
        {
            return await httpClient.GetFromJsonAsync<Joke>("random_joke");
        }

        public async Task<List<Joke>> GetTenJoke()
        {
            return await httpClient.GetFromJsonAsync<List<Joke>>("random_ten");
        }
    }
}

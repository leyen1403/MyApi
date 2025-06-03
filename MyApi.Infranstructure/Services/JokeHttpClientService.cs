using MyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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

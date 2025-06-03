using MyApi.Core.Interfaces;
using MyApi.Core.Models;
using MyApi.Infranstructure.Services;

namespace MyApi.Infranstructure.Repositories
{
    public class ExternalVendorRepository : IExternalVendorRepository
    {
        JsonplaceholderHttpClientService _jsonplaceholderHttpClientService;
        JokeHttpClientService _jokeHttpClientService;

        public ExternalVendorRepository(JsonplaceholderHttpClientService jsonplaceholderHttpClientService, JokeHttpClientService jokeHttpClientService)
        {
            _jsonplaceholderHttpClientService = jsonplaceholderHttpClientService;
            _jokeHttpClientService = jokeHttpClientService;
        }

        public async Task<List<Jsonplaceholder>> GetData()
        {
            return await _jsonplaceholderHttpClientService.GetData();
        }

        public async Task<Joke?> GetRandomJokeAsync()
        {
            return await _jokeHttpClientService.GetRandomJokeAsync();
        }

        public async Task<List<Joke>?> GetTenJoke()
        {
            return await _jokeHttpClientService.GetTenJoke();
        }
    }
}

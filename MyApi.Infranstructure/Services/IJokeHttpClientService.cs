using MyApi.Core.Models;

namespace MyApi.Infranstructure.Services
{
    public interface IJokeHttpClientService
    {
        Task<Joke?> GetRandomJokeAsync();
        Task<List<Joke>?> GetTenJoke();
    }
}
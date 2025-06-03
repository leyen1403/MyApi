using MyApi.Core.Models;

namespace MyApi.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<List<Jsonplaceholder>> GetData();
        Task<Joke?> GetRandomJokeAsync();
        Task<List<Joke>?> GetTenJoke();
    }
}

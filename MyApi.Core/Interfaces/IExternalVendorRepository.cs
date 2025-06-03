using MyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<List<Jsonplaceholder>> GetData();
        Task<Joke?> GetRandomJokeAsync();
        Task<List<Joke>?> GetTenJoke();
    }
}

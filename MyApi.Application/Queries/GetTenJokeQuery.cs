using MediatR;
using MyApi.Core.Interfaces;
using MyApi.Core.Models;

namespace MyApi.Application.Queries
{
    public record GetTenJokeQuery() : IRequest<List<Joke>>;

    public class GetTenJokeQueryHandler : IRequestHandler<GetTenJokeQuery, List<Joke>>
    {
        private readonly IExternalVendorRepository _externalVendorRepository;
        public GetTenJokeQueryHandler(IExternalVendorRepository externalVendorRepository)
        {
            _externalVendorRepository = externalVendorRepository;
        }
        public async Task<List<Joke>> Handle(GetTenJokeQuery request, CancellationToken cancellationToken)
        {
            var tenJokes = await _externalVendorRepository.GetTenJoke();
            if (tenJokes == null)
            {
                throw new Exception("No jokes found");
            }
            return tenJokes;
        }
    }
}

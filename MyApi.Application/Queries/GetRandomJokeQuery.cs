﻿using MediatR;
using MyApi.Core.Interfaces;
using MyApi.Core.Models;

namespace MyApi.Application.Queries
{
    public record GetRandomJokeQuery():IRequest<Joke>;

    public class GetRandomJokeQueryHandler : IRequestHandler<GetRandomJokeQuery, Joke>
    {
        private readonly IExternalVendorRepository _externalVendorRepository;
        public GetRandomJokeQueryHandler(IExternalVendorRepository externalVendorRepository)
        {
            _externalVendorRepository = externalVendorRepository;
        }
        public async Task<Joke> Handle(GetRandomJokeQuery request, CancellationToken cancellationToken)
        {
            var joke = await _externalVendorRepository.GetRandomJokeAsync();
            if (joke == null)
            {
                throw new Exception("No joke found");
            }
            return joke;
        }
    }
}

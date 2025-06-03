using MediatR;
using MyApi.Core.Interfaces;
using MyApi.Core.Models;

namespace MyApi.Application.Queries
{
    public record GetJsonplaceholderDataQuery() : IRequest<List<Jsonplaceholder>>;

    public class GetJsonplaceholderDataQueryHandler : IRequestHandler<GetJsonplaceholderDataQuery, List<Jsonplaceholder>>
    {
        private readonly IExternalVendorRepository _externalVendorRepository;

        public GetJsonplaceholderDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        {
            _externalVendorRepository = externalVendorRepository;
        }

        public async Task<List<Jsonplaceholder>> Handle(GetJsonplaceholderDataQuery request, CancellationToken cancellationToken)
        {
            return await _externalVendorRepository.GetData();
        }
    }
}

﻿using MediatR;
using MyApi.Core.Entities;
using MyApi.Core.Interfaces;

namespace MyApi.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid id) : IRequest<EmployeeEntity>;

    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(request.id);
        }
    }
}

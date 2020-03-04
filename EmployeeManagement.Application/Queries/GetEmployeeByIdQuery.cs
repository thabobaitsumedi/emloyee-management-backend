using EmployeeManagement.Application.Messages;
using MediatR;
using System;

namespace EmployeeManagement.Application.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResponse>
    {
        public Guid EmployeeId { get; set; }
    }
}
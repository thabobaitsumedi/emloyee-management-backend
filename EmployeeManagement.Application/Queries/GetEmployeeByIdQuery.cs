using EmployeeManagement.Application.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResponse>
    {
        public Guid EmployeeId { get; set; }
    }
}

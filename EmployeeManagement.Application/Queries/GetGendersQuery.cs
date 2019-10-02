using EmployeeManagement.Application.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Queries
{
    public class GetGendersQuery : IRequest<GetGendersQueryResponse>
    {
    }
}

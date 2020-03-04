using EmployeeManagement.Application.Messages;
using MediatR;

namespace EmployeeManagement.Application.Queries
{
    public class GetAllEmployeesQuery : IRequest<GetAllEmployeesQueryResponse>
    {
    }
}
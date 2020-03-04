using EmployeeManagement.Application.Messages;
using MediatR;

namespace EmployeeManagement.Application.Queries
{
    public class GetAddressTypesQuery : IRequest<GetAddressTypesQueryResponse>
    {
    }
}
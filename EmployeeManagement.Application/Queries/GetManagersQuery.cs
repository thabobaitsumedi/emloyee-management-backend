using EmployeeManagement.Application.Messages;
using MediatR;

namespace EmployeeManagement.Application.Queries
{
    public class GetManagersQuery : IRequest<GetManagersQueryResponse>
    {
    }
}
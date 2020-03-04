using EmployeeManagement.Application.Messages;
using MediatR;

namespace EmployeeManagement.Application.Queries
{
    public class GetJobsQuery : IRequest<GetJobsQueryResponse>
    {
    }
}
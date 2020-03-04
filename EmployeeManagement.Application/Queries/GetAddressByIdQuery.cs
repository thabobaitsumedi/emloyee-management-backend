using EmployeeManagement.Application.Messages;
using MediatR;

namespace EmployeeManagement.Application.Queries
{
    public class GetAddressByIdQuery : IRequest<GetAddressByIdQueryResponse>
    {
        public int AddressId { get; set; }
    }
}
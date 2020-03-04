using EmployeeManagement.Application.Messages;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Queries
{
    public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery, GetAddressByIdQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetAddressByIdQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetAddressByIdQueryResponse> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var address = await _context.Address.FindAsync(request.AddressId);
            var response = new GetAddressByIdQueryResponse();
            if (address != null)
            {
                response.AddressId = address.AddressId;
                response.Line1 = address.Line1;
                response.Line2 = address.Line2;
                response.PostalCode = address.PostalCode;
                response.AddressTypeId = address.AddressTypeId;
            }

            return response;
        }
    }
}
using EmployeeManagement.Application.Messages;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Queries
{
    public class GetAddressTypesQueryHandler : IRequestHandler<GetAddressTypesQuery, GetAddressTypesQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetAddressTypesQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetAddressTypesQueryResponse> Handle(GetAddressTypesQuery request, CancellationToken cancellationToken)
        {
            var response = new GetAddressTypesQueryResponse()
            {
                AddressTypes = await (from address in _context.AddressType
                                      select
new AddressTypeResponse()
{
  AddressTypeId = address.AddressTypeId,
  AddressDescription = address.AddressDescription
}).ToListAsync()
            };

            return response;
        }
    }
}
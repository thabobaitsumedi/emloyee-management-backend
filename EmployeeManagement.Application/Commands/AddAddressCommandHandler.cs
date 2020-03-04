using EmployeeManagement.Application.Messages;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Commands
{
    public class AddAddressCommandHandler : IRequestHandler<AddAddressCommand, AddAddressCommandResponse>
    {
        private readonly EmployeeDevContext _context;

        public AddAddressCommandHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<AddAddressCommandResponse> Handle(AddAddressCommand request, CancellationToken cancellationToken)
        {
            var response = new AddAddressCommandResponse();

            if (request != null)
            {
                var newAddress = new Address()
                {
                    Line1 = request.Line1,
                    Line2 = request.Line2,
                    PostalCode = request.PostalCode,
                    AddressTypeId = request.AddressTypeId
                };

                await _context.Address.AddAsync(newAddress);
                await _context.SaveChangesAsync();
                response.AddressId = newAddress.AddressId;
                response.Message = "Address Successfully Added!";
            }
            else
            {
                response.Message = "Could not add the address!";
            }

            return response;
        }
    }
}
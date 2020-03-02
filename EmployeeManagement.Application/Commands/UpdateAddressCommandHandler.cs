using EmployeeManagement.Application.Messages;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Commands
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, UpdateAddressCommandResponse>
    {
        private readonly EmployeeDevContext _context;

        public UpdateAddressCommandHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _context.Address.FindAsync(request.AddressId);
            var response = new UpdateAddressCommandResponse();

            if (address != null)
            {
                var updatedAddress = CreateUpdatedAddress(address, request);
                _context.Address.Update(updatedAddress);
                await _context.SaveChangesAsync();
                response.Message = "Address Successfully Updated!";
            }
            else
            {
                response.Message = "Could not find address: " + request.AddressId;
            }

            return response;
        }

        private Address CreateUpdatedAddress(Address address, UpdateAddressCommand request)
        {
            address.Line1 = request.Line1;
            address.Line2 = request.Line2;
            address.PostalCode = request.PostalCode;
            address.AddressTypeId = request.AddressTypeId;

            return address;
        }
    }
}

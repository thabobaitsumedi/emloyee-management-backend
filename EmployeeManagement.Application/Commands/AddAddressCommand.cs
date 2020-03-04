using EmployeeManagement.Application.Messages;
using MediatR;

namespace EmployeeManagement.Application.Commands
{
    public class AddAddressCommand : IRequest<AddAddressCommandResponse>
    {
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public int PostalCode { get; set; }

        public int AddressTypeId { get; set; }
    }
}
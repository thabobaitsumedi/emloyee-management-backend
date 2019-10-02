using EmployeeManagement.Application.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Commands
{
    public class UpdateAddressCommand : IRequest<UpdateAddressCommandResponse>
    {
        public int AddressId { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public int PostalCode { get; set; }

        public int addressTypeId { get; set; }
    }
}

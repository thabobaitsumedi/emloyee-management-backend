using FluentValidation;
using EmployeeManagement.Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Validators
{
    public class AddAddressValidator : AbstractValidator<AddAddressCommand>
    {
        public AddAddressValidator()
        {
            RuleFor(address => address.Line1)
                .NotEmpty().WithMessage("Please ensure you have entered your street address");

            RuleFor(address => address.PostalCode)
                .NotEmpty().WithMessage("Please ensure you have entered your postal code");

            RuleFor(address => address.AddressTypeId)
                .NotEmpty().WithMessage("Please ensure you have selected your address type");
        }
    }
}

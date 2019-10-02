using EmployeeManagement.Application.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Validators
{
    public class AddEmployeeValidator : AbstractValidator<AddEmployeeCommand>
    {
        public AddEmployeeValidator()
        {
            RuleFor(emp => emp.FirstName)
                .NotEmpty().WithMessage("Please ensure you have entered your first Name")
                .Length(2, 30).WithMessage("First name must be between 3 and 30 characters");

            RuleFor(emp => emp.LastName)
                .NotEmpty().WithMessage("Please ensure you have entered your Last Name")
                .NotEqual(emp => emp.FirstName)
                .Length(2, 30).WithMessage("Last name must be between 2 and 30 characters");

            RuleFor(emp => emp.GenderId)
                .NotEmpty().WithMessage("Please Select your Gender");

            RuleFor(emp => emp.DepartmentId)
                .NotEmpty().WithMessage("Please Select your Department");

            RuleFor(emp => emp.ManagerId)
                .NotEmpty().WithMessage("Please Select your Manager");

            RuleFor(emp => emp.JobId)
                .NotEmpty().WithMessage("Please Select your Job Type");

            RuleFor(emp => emp.AddressId)
                .NotEmpty().WithMessage("Please Select your Address");

            RuleFor(emp => emp.DoB)
                .NotEmpty().WithMessage("Please Select your Date of Birth");

            RuleFor(emp => emp.PhoneNumber)
                .NotEmpty().WithMessage("Please enter your Phone number")
                .Length(10, 13).WithMessage("Phone number must be between 10 and 13 characters if you include country code");

            RuleFor(emp => emp.HireDate)
                .NotEmpty().WithMessage("Please Select your Hire Date");
            
            RuleFor(emp => emp.EmailAddress)
               .NotEmpty().WithMessage("Please Enter your valid email address")
               .EmailAddress();
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Validators
{
    public class BaseValidator<T> : AbstractValidator<T> where T : class
    {
       
    }
}

using FluentValidation;

namespace EmployeeManagement.Application.Validators
{
    public class BaseValidator<T> : AbstractValidator<T> where T : class
    {
    }
}
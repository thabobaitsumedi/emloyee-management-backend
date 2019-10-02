using EmployeeManagement.Application.Messages;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Application.Commands
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, AddEmployeeCommandResponse>
    {
        private readonly EmployeeDevContext _context;

        public AddEmployeeCommandHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<AddEmployeeCommandResponse> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emailExist = await _context.Employee.FirstOrDefaultAsync(emp => emp.EmailAddress.ToLowerInvariant() == request.EmailAddress.ToLowerInvariant());
            var dobExist = await _context.Employee.FirstOrDefaultAsync(emp => emp.DoB == request.DoB);
            var response = new AddEmployeeCommandResponse();

            if(emailExist != null && dobExist != null)
            {
                response.Message = "This Employee already Exist!";
            }
            else
            {
                var newEmployee = CreateEmployee(request);
                await _context.Employee.AddAsync(newEmployee);
                await _context.SaveChangesAsync();
                response.Message = "Employee Successfully Added!";
            }

            return response;
        }

        private Employee CreateEmployee(AddEmployeeCommand request)
        {
            var employee = new Employee()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                DoB = request.DoB,
                PhoneNumber = request.PhoneNumber,
                EmailAddress = request.EmailAddress,
                HireDate = request.HireDate,
                GenderId = request.GenderId,
                ManagerId = request.ManagerId,
                JobId = request.JobId,
                DepartmentId = request.DepartmentId,
                AddressId = request.AddressId
            };

            return employee;
        }
    }
}

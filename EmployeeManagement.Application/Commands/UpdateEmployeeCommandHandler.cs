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
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, UpdateEmployeeCommandResponse>
    {
        private readonly EmployeeDevContext _context;

        public UpdateEmployeeCommandHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<UpdateEmployeeCommandResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employee.FindAsync(request.EmployeeId);
            var response = new UpdateEmployeeCommandResponse();

            if(employee != null)
            {
                var updatedEmployee = CreateUpdatedEmployee(employee, request);
                _context.Employee.Update(updatedEmployee);
                await _context.SaveChangesAsync();
                response.Message = "Employee Successfully Updated!";
            }
            else
            {
                response.Message = "Could not find employee: " + request.EmployeeId;
            }

            return response;
        }

        private Employee CreateUpdatedEmployee(Employee employee, UpdateEmployeeCommand request)
        {
            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.DoB = request.DoB;
            employee.PhoneNumber = request.PhoneNumber;
            employee.EmailAddress = request.EmailAddress;
            employee.HireDate = request.HireDate;
            employee.DepartmentId = request.DepartmentId;
            employee.GenderId = request.GenderId;
            employee.ManagerId = request.ManagerId;
            employee.JobId = request.JobId;
            employee.AddressId = request.AddressId;

            return employee;
        }
    }
}

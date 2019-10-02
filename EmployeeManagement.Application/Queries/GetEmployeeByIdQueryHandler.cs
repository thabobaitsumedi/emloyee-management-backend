using EmployeeManagement.Application.Messages;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeManagement.Application.Queries
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, GetEmployeeByIdQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetEmployeeByIdQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetEmployeeByIdQueryResponse> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employee.FindAsync(request.EmployeeId);
            var response = new GetEmployeeByIdQueryResponse();
            if (employee != null)
            {
                response.EmployeeId = employee.EmployeeId;
                response.FirstName = employee.FirstName;
                response.LastName = employee.LastName;
                response.DoB = employee.DoB;
                response.EmailAddress = employee.EmailAddress;
                response.PhoneNumber = employee.PhoneNumber;
                response.AddressId = employee.AddressId;
                response.DepartmentId = employee.DepartmentId;
                response.GenderId = employee.GenderId;
                response.HireDate = employee.HireDate;
                response.JobId = employee.JobId;
                response.ManagerId = employee.ManagerId;
            }

            return response;
        }
    }
}

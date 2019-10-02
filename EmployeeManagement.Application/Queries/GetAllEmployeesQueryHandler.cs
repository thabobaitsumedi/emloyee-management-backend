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
    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, GetAllEmployeesQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetAllEmployeesQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetAllEmployeesQueryResponse> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {

            var response = new GetAllEmployeesQueryResponse()
            {
                Employees = await (from employee in _context.Employee select
                                   new EmployeesResponse()
                                   {
                                       EmployeeId = employee.EmployeeId,
                                       FirstName = employee.FirstName,
                                       LastName = employee.LastName,
                                       DoB = employee.DoB,
                                       PhoneNumber = employee.PhoneNumber,
                                       EmailAddress = employee.EmailAddress,
                                       HireDate = employee.HireDate,
                                       AddressId = employee.Address.AddressId,
                                       GenderId = employee.Gender.GenderId,
                                       GenderDescription = employee.Gender.GenderDescription,
                                       JobId = employee.Job.JobId,
                                       JobTitle = employee.Job.JobTitle,
                                       DepartmentId = employee.Department.DepartmentId,
                                       DepartmentName = employee.Department.DepartmentName,
                                       ManagerId = employee.Manager.ManagerId,
                                       ManagerName = employee.Manager.ManagerName
                                   }).ToListAsync()
            };
             
            return response;
        }
    }
}

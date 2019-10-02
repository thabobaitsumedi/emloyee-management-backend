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
    public class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, GetDepartmentsQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetDepartmentsQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetDepartmentsQueryResponse> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
        {
             var response = new GetDepartmentsQueryResponse()
            {
                Departments = await (from department in _context.Department select
                                   new DepartmentResponse()
                                   {
                                       DepartmentId = department.DepartmentId,
                                       DepartmentName = department.DepartmentName
                                   }).ToListAsync()
            };

            return response;
        }
    }
}

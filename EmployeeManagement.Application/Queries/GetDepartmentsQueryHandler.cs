using EmployeeManagement.Application.Messages;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
                Departments = await (from department in _context.Department
                                     select
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
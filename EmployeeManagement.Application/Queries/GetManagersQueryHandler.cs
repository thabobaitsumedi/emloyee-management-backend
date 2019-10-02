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
    public class GetManagersQueryHandler : IRequestHandler<GetManagersQuery, GetManagersQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetManagersQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetManagersQueryResponse> Handle(GetManagersQuery request, CancellationToken cancellationToken)
        {
             var response = new GetManagersQueryResponse()
            {
                Managers = await (from manager in _context.Manager select
                                   new ManagerResponse()
                                   {
                                       ManagerId = manager.ManagerId,
                                       ManagerName = manager.ManagerName
                                   }).ToListAsync()
            };

            return response;
        }
    }
}

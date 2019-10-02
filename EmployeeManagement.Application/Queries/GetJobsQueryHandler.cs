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
    public class GetJobsQueryHandler : IRequestHandler<GetJobsQuery, GetJobsQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetJobsQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetJobsQueryResponse> Handle(GetJobsQuery request, CancellationToken cancellationToken)
        {
            
            var response = new GetJobsQueryResponse()
            {
                Jobs = await (from job in _context.Job select
                                   new JobResponse()
                                   {
                                       JobId = job.JobId,
                                       JobTitle = job.JobTitle
                                   }).ToListAsync()
            };

            return response;
        }
    }
}

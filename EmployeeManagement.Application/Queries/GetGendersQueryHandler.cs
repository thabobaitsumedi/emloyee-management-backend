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
    public class GetGendersQueryHandler : IRequestHandler<GetGendersQuery, GetGendersQueryResponse>
    {
        private readonly EmployeeDevContext _context;

        public GetGendersQueryHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<GetGendersQueryResponse> Handle(GetGendersQuery request, CancellationToken cancellationToken)
        {
            var response = new GetGendersQueryResponse()
            {
                Genders = await (from gender in _context.Gender select
                                   new GenderResponse()
                                   {
                                       GenderId = gender.GenderId,
                                       GenderDescription = gender.GenderDescription
                                   }).ToListAsync()
            };

            return response;
        }
    }
}

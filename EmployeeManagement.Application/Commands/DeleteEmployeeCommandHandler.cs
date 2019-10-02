using EmployeeManagement.Application.Messages;
using EmployeeManagement.Persistence.ContextClass;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Commands
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, DeleteEmployeeCommandResponse>
    {
        private readonly EmployeeDevContext _context;

        public DeleteEmployeeCommandHandler(EmployeeDevContext _context)
        {
            this._context = _context;
        }

        public async Task<DeleteEmployeeCommandResponse> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employee.FindAsync(request.EmployeeId);
            var response = new DeleteEmployeeCommandResponse();

            if(employee != null)
            {
                _context.Employee.Remove(employee);
                await _context.SaveChangesAsync();
                response.Message = "employee deleted successfully.";
            }
            else
            {
                response.Message = "employee with id: " + request.EmployeeId + " is not found.";
            }

            return response;
        }
    }
}

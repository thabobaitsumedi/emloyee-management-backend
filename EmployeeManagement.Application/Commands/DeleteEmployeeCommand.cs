using EmployeeManagement.Application.Messages;
using MediatR;
using System;

namespace EmployeeManagement.Application.Commands
{
    public class DeleteEmployeeCommand : IRequest<DeleteEmployeeCommandResponse>
    {
        public Guid EmployeeId { get; set; }
    }
}
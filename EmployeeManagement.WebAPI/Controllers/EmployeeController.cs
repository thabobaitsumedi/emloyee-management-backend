using EmployeeManagement.Application.Commands;
using EmployeeManagement.Application.Messages;
using EmployeeManagement.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmployeeManagement.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator _mediator)
        {
            this._mediator = _mediator;
        }

        /// <summary>
        /// Get available employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllEmployees")]
        public async Task<GetAllEmployeesQueryResponse> GetAllEmployees()
        {
            return await _mediator.Send(new GetAllEmployeesQuery());
        }

        /// <summary>
        /// Get all genders
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetGenders")]
        public async Task<GetGendersQueryResponse> GetGenders()
        {
            return await _mediator.Send(new GetGendersQuery());
        }

        /// <summary>
        /// Get all address types
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAddressTypes")]
        public async Task<GetAddressTypesQueryResponse> GetAddressTypes()
        {
            return await _mediator.Send(new GetAddressTypesQuery());
        }

        /// <summary>
        /// Get all departments
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetDepartments")]
        public async Task<GetDepartmentsQueryResponse> GetDepartments()
        {
            return await _mediator.Send(new GetDepartmentsQuery());
        }

        /// <summary>
        /// Get all job types
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetJobs")]
        public async Task<GetJobsQueryResponse> GetJobs()
        {
            return await _mediator.Send(new GetJobsQuery());
        }

        /// <summary>
        /// Get all managers
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetManagers")]
        public async Task<GetManagersQueryResponse> GetManagers()
        {
            return await _mediator.Send(new GetManagersQuery());
        }

        /// <summary>
        /// Search for specific address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        [HttpGet("GetAddressById/{addressId}")]
        public async Task<GetAddressByIdQueryResponse> GetAddressById(int addressId)
        {
            return await _mediator.Send(new GetAddressByIdQuery
            {
                AddressId = addressId
            });
        }

        /// <summary>
        /// Search for specific employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet("GetEmployeeById/{employeeId}")]
        public async Task<GetEmployeeByIdQueryResponse> GetEmployeeById(Guid employeeId)
        {
            return await _mediator.Send(new GetEmployeeByIdQuery
            {
                EmployeeId = employeeId
            });
        }

        /// <summary>
        /// Add new employee
        /// </summary>
        /// <param name="employee"></param>
        [HttpPost("AddEmployee")]
        public async Task<AddEmployeeCommandResponse> AddEmployee([FromBody] AddEmployeeCommand employee)
        {
            return await _mediator.Send(employee);
        }

        /// <summary>
        /// Add new address
        /// </summary>
        /// <param name="address"></param>
        [HttpPost("AddAddress")]
        public async Task<AddAddressCommandResponse> AddAddress([FromBody] AddAddressCommand address)
        {
            return await _mediator.Send(address);
        }

        /// <summary>
        /// Update specific employee
        /// </summary>
        /// <param name="employee"></param>
        [HttpPut("UpdateEmployee")]
        public async Task<UpdateEmployeeCommandResponse> UpdateEmployee([FromBody] UpdateEmployeeCommand employee)
        {
            return await _mediator.Send(employee);
        }

        /// <summary>
        /// Update specific address
        /// </summary>
        /// <param name="address"></param>
        [HttpPut("UpdateAddress")]
        public async Task<UpdateAddressCommandResponse> UpdateAddress([FromBody] UpdateAddressCommand address)
        {
            return await _mediator.Send(address);
        }

        /// <summary>
        /// Deletes specific employee
        /// </summary>
        /// <param name="employeeId"></param>
        [HttpDelete("DeleteEmployee/{employeeId}")]
        public async Task<DeleteEmployeeCommandResponse> DeleteEmployee(Guid employeeId)
        {
            return await _mediator.Send(new DeleteEmployeeCommand
            {
                EmployeeId = employeeId
            });
        }
    }
}
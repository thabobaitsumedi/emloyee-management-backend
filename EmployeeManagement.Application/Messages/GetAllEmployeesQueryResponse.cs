using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Messages
{
    public class GetAllEmployeesQueryResponse
    {
        public GetAllEmployeesQueryResponse()
        {
            Employees = new List<EmployeesResponse>();
        }

        public List<EmployeesResponse> Employees { get; set; }
    }

    public class EmployeesResponse
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime HireDate { get; set; }
        public int ManagerId { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public int AddressId { get; set; }
        public int GenderId { get; set; }
        public string ManagerName { get; set; }
        public string JobTitle { get; set; }
        public string DepartmentName { get; set; }
        public string GenderDescription { get; set; }

    }
}

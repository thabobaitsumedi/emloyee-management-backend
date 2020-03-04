using System;

namespace EmployeeManagement.Domain.Entities
{
    public partial class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime HireDate { get; set; }
        public int GenderId { get; set; }
        public int ManagerId { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Department Department { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Job Job { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
            Manager = new HashSet<Manager>();
            ManagerDepartment = new HashSet<ManagerDepartment>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Manager> Manager { get; set; }
        public virtual ICollection<ManagerDepartment> ManagerDepartment { get; set; }
    }
}

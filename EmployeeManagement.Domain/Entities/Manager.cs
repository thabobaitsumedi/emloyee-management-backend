using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class Manager
    {
        public Manager()
        {
            Employee = new HashSet<Employee>();
            ManagerDepartment = new HashSet<ManagerDepartment>();
        }

        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<ManagerDepartment> ManagerDepartment { get; set; }
    }
}
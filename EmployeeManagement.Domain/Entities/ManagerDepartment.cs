using System;
using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class ManagerDepartment
    {
        public int ManagerDepartmentId { get; set; }
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Manager Manager { get; set; }
    }
}

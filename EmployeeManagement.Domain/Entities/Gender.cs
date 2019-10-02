using System;
using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            Employee = new HashSet<Employee>();
        }

        public int GenderId { get; set; }
        public string GenderDescription { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}

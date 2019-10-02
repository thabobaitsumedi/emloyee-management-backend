using System;
using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class Job
    {
        public Job()
        {
            Employee = new HashSet<Employee>();
        }

        public int JobId { get; set; }
        public string JobTitle { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class Address
    {
        public Address()
        {
            Employee = new HashSet<Employee>();
        }

        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public int PostalCode { get; set; }
        public int AddressTypeId { get; set; }

        public virtual AddressType AddressType { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}

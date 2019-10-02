using System;
using System.Collections.Generic;

namespace EmployeeManagement.Domain.Entities
{
    public partial class AddressType
    {
        public AddressType()
        {
            Address = new HashSet<Address>();
        }

        public int AddressTypeId { get; set; }
        public string AddressDescription { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}

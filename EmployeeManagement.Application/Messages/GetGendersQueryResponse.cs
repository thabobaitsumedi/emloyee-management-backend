using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Messages
{
    public class GetGendersQueryResponse
    {
        public GetGendersQueryResponse()
        {
            Genders = new List<GenderResponse>();
        }

        public List<GenderResponse> Genders { get; set; }
    }

    public class GenderResponse
    {
        public int GenderId { get; set; }

        public string GenderDescription { get; set; }
    }
}

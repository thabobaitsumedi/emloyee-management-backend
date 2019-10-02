using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Messages
{
    public class GetDepartmentsQueryResponse
    {
        public GetDepartmentsQueryResponse()
        {
            Departments = new List<DepartmentResponse>();
        }

        public List<DepartmentResponse> Departments { get; set; }
    }

    public class DepartmentResponse
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}

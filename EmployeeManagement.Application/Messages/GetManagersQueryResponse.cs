using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Messages
{
    public class GetManagersQueryResponse
    {
        public GetManagersQueryResponse()
        {
            Managers = new List<ManagerResponse>();
        }

        public List<ManagerResponse> Managers { get; set; }
    }

    public class ManagerResponse
    {
        public int ManagerId { get; set; }

        public string ManagerName { get; set; }
    }
}

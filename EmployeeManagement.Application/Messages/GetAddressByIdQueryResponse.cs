namespace EmployeeManagement.Application.Messages
{
    public class GetAddressByIdQueryResponse
    {
        public int AddressId { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public int PostalCode { get; set; }

        public int AddressTypeId { get; set; }
    }
}
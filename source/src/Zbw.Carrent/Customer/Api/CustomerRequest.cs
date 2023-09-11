using Zbw.Carrent.Customer.Api.Address;

namespace Zbw.Carrent.Customer.Api
{
    public class CustomerRequest
    {
        public int CustomerNr { get; set; }
        public string Name { get; set; }
        public CustomerResponseAddress Address { get; set; }
    }
}

using Zbw.Carrent.Domains.Address.Api;

namespace Zbw.Carrent.Domains.Customer.Api
{
    public class CustomerRequest
    {
        public int CustomerNr { get; set; }
        public string Name { get; set; }
        public AddressDto Address { get; set; }
    }
}

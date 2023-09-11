using Zbw.Carrent.Domains.Address.Api;

namespace Zbw.Carrent.Domains.Customer.Api
{
    public class CustomerMapper
    {
        public CustomerMapper() { }

        public CustomerResponse ConvertToResponse(Customer customer)
        {
            var customerResponse = new CustomerResponse()
            {
                CustomerNr = customer.CustomerNr,
                Name = customer.Name,
                Address = ConvertToDto(customer.Address),
            };

            return customerResponse;
        }

        public Customer ConvertToCustomer(CustomerRequest customerRequest)
        {
            var customer = new Customer(
                customerRequest.Name,
                customerRequest.Address.Street,
                customerRequest.Address.Plz,
                customerRequest.Address.City)
            {
                CustomerNr = customerRequest.CustomerNr,
            };

            return customer;
        }

        private AddressDto ConvertToDto(Address.Address address)
        {
            var addressDto = new AddressDto(address.Street, address.Plz, address.City)
            {
                Id = address.Id,
            };

            return addressDto;
        }
    }
}

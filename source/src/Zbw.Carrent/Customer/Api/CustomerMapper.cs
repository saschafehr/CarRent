using Zbw.Carrent.Customer.Api.Address;
using Zbw.Carrent.Customer.Domain;

namespace Zbw.Carrent.Customer.Api
{
    public class CustomerMapper
    {
        public CustomerMapper() { }

        public CustomerResponse ConvertToResponse(Domain.Customer.Customer customer)
        {
            var customerResponse = new CustomerResponse()
            {
                CustomerNr = customer.CustomerNr,
                Name = customer.Name,
                Address = ConvertToApiAddress<CustomerResponseAddress>(customer.Address),
            };

            return customerResponse;
        }

        public Domain.Customer.Customer ConvertToCustomer(CustomerRequest customerRequest)
        {
            var customer = new Domain.Customer.Customer(
                customerRequest.Name,
                customerRequest.Address.Street,
                customerRequest.Address.Plz,
                customerRequest.Address.City)
            {
                CustomerNr = customerRequest.CustomerNr,
            };

            return customer;
        }

        private T ConvertToApiAddress<T>(Domain.Address address) where T : IApiAddress
        {
            var type = typeof(T);
            var instance = Activator.CreateInstance(type);

            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                switch (property.Name)
                {
                    case "Id":
                        property.SetValue(instance, address.Id);
                        break;
                    case "Street":
                        property.SetValue(instance, address.Street);
                        break;
                    case "City":
                        property.SetValue(instance, address.City);
                        break;
                    case "Plz":
                        property.SetValue(instance, address.Plz);
                        break;
                }
            }

            return (T)instance;
        }
    }
}

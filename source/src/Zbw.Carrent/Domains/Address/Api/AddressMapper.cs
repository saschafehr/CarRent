namespace Zbw.Carrent.Domains.Address.Api
{
    public class AddressMapper
    {
        public AddressDto ConvertToDto(Address address)
        {
            var addressDto = new AddressDto(address.Street, address.Plz, address.City)
            {
                Id = address.Id,
            };

            return addressDto;
        }

        public Address ConvertToAddress(AddressDto addressDto)
        {
            var addresse = new Address(addressDto.Street, addressDto.Plz, addressDto.City)
            {
                Id = addressDto.Id,
            };

            return addresse;
        }
    }
}

namespace Zbw.Carrent.Domains.Address.Api
{
    public class AddressDto
    {
        public AddressDto(string street, int plz, string city)
        {
            Street = street;
            Plz = plz;
            City = city;
        }
        public int Id { get; set; }
        public string Street { get; set; }
        public int Plz { get; set; }
        public string City { get; set; }
    }
}

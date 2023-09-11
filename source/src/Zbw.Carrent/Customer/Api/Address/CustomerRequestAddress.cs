namespace Zbw.Carrent.Customer.Api.Address
{
    public class CustomerRequestAddress : IApiAddress
    {
        public CustomerRequestAddress(string street, int plz, string city)
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

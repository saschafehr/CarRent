namespace Zbw.Carrent.Customer.Domain
{
    public class Address
    {
        public Address(string street, int plz, string city)
        {
            Street = street;
            Plz = plz;
            City = city;
        }
        public int Id { get; set; }
        public string Street { get; set; }
        public int Plz { get; set; }
        public string City { get; set; }
        public virtual ICollection<Customer.Customer> Customer { get; set; }
    }
}

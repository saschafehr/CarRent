namespace Zbw.Carrent.Domains.Customer
{
    public class Customer
    {
        public Customer(string name, string street, int plz, string city)
        {
            Name = name;
            Address = new Address.Address(street, plz, city);
        }

        private Customer() { }

        public int CustomerNr { get; set; }

        public string Name { get; set; }

        public int AddressId { get; set; }
        public virtual Address.Address Address { get; set; }

        public virtual ICollection<Reservation.Reservation> Reservations { get; set; }
    }
}

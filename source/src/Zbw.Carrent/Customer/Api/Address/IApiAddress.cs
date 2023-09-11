namespace Zbw.Carrent.Customer.Api.Address
{
    public interface IApiAddress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Plz { get; set; }
        public string City { get; set; }
    }
}

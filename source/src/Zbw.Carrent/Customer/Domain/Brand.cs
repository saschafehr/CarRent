namespace Zbw.Carrent.Customer.Domain
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        public virtual Car Car { get; set; }
    }
}

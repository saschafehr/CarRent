namespace Zbw.Carrent.Domains.Brand
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        public virtual Car.Car Car { get; set; }
    }
}

namespace Zbw.Carrent.Domains.Categories
{
    public abstract class Category
    {
        public int CategoryId { get; set; }
        public abstract decimal DailyFee { get; set; }

        public virtual ICollection<Car.Car> Cars { get; set; }
    }
}

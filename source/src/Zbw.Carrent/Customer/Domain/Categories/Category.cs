namespace Zbw.Carrent.Customer.Domain.Categories
{
    public abstract class Category
    {
        public int CategoryId { get; set; }
        public abstract decimal DailyFee { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}

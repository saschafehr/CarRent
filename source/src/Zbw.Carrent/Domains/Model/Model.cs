namespace Zbw.Carrent.Domains.Model
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Car.Car Car { get; set; }
    }
}

using Zbw.Carrent.Domains.Brand.Api;
using Zbw.Carrent.Domains.Categories;
using Zbw.Carrent.Domains.Categories.Api;
using Zbw.Carrent.Domains.Model.Api;

namespace Zbw.Carrent.Domains.Car.Api
{
    public class CarDto
    {
        public int CarNr { get; set; }
        public BrandDto Brand { get; set; }
        public ModelDto Model { get; set; }
        public CategoryDto Category { get; set; }
    }
}

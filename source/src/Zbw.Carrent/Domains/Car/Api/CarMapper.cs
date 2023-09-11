using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Diagnostics;
using Zbw.Carrent.Domains.Brand.Api;
using Zbw.Carrent.Domains.Categories;
using Zbw.Carrent.Domains.Categories.Api;
using Zbw.Carrent.Domains.Model.Api;

namespace Zbw.Carrent.Domains.Car.Api
{
    public class CarMapper
    {
        private BrandMapper _brandMapper;
        private ModelMapper _modelmapper;
        private CategoryMapper _categoryMapper;
        public CarMapper() { }

        public Car ConvertToCar(CarDto carDto)
        {
            var car = new Car()
            {
                CarNr = carDto.CarNr,
                BrandId = carDto.Brand.BrandId,
                Brand = _brandMapper.ConvertToBrand(carDto.Brand),
                ModelId = carDto.Model.Id,
                Model = _modelmapper.ConvertToModel(carDto.Model),
                CategoryId = carDto.Category.CategoryId,
                Category = _categoryMapper.ConvertToCategory<Category>(carDto.Category),
            };

            return car;
        }

        public CarDto ConvertToDto(Car car)
        {
            var dto = new CarDto()
            {
                CarNr = car.CarNr,
                Brand = _brandMapper.ConvertToDto(car.Brand),
                Model = _modelmapper.ConvertToDto(car.Model),
                Category = _categoryMapper.ConvertToDto(car.Category),
            };

            return dto;
        }
    }
}

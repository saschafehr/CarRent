namespace Zbw.Carrent.Domains.Brand.Api
{
    public class BrandMapper
    {
        public Brand ConvertToBrand(BrandDto brandDto)
        {
            var brand = new Brand()
            {
                BrandId = brandDto.BrandId,
                Name = brandDto.Name,
            };

            return brand;
        }

        public BrandDto ConvertToDto(Brand brand)
        {
            var dto = new BrandDto()
            {
                BrandId = brand.BrandId,
                Name = brand.Name,
            };

            return dto;
        }
    }
}

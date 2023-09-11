namespace Zbw.Carrent.Domains.Categories.Api
{
    public class CategoryMapper
    {
        public T ConvertToCategory<T>(CategoryDto categoryDto) where T : Category
        {
            var type = typeof(T);
            var categoryIdProperty = type.GetProperty("CategoryId");
            var dailyFeeProperty = type.GetProperty("DailyFee");
            var instance = Activator.CreateInstance(type);

            categoryIdProperty?.SetValue(instance, categoryDto.CategoryId, null);
            dailyFeeProperty?.SetValue(instance, categoryDto.DailyFee, null);

            return (T)instance;
        }

        public CategoryDto ConvertToDto<T>(T category) where T : Category
        {
            var type = typeof(T);
            var categoryIdProperty = type.GetProperty("CategoryId");
            var dailyFeeProperty = type.GetProperty("DailyFee");
            var instance = Activator.CreateInstance(type);

            var dto = new CategoryDto()
            {
                CategoryId = (int)categoryIdProperty.GetValue(instance),
                DailyFee = (decimal)dailyFeeProperty.GetValue(instance),
            };

            return dto;
        }
    }
}

namespace Zbw.Carrent.Domains.Model.Api
{
    public class ModelMapper
    {
        public Model ConvertToModel(ModelDto modelDto)
        {
            var model = new Model()
            {
                Id = modelDto.Id,
                Name = modelDto.Name,
            };

            return model;
        }

        public ModelDto ConvertToDto(Model model)
        {
            var dto = new ModelDto()
            {
                Id = model.Id,
                Name = model.Name,
            };

            return dto;
        }
    }
}

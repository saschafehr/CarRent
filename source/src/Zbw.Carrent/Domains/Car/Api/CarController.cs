using Microsoft.AspNetCore.Mvc;
using Zbw.Carrent.Domains.Car.Infrastructur;
using Zbw.Carrent.Shared;

namespace Zbw.Carrent.Domains.Car.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController
    {
        private CarRepository _carRepository;
        private CarMapper _mapper;
        public CarController(ApplicationContext context)
        {
            _carRepository = new CarRepository(context);
            _mapper = new CarMapper();
        }

        // GET
        [HttpGet]
        public IEnumerable<CarDto> Get()
        {
            var result = _carRepository.GetAll();
            foreach (var item in result)
            {
                var response = _mapper.ConvertToDto(item);
                yield return response;
            }
        }

        // GET
        [HttpGet("{id}")]
        public CarDto Get(int id)
        {
            var result = _carRepository.GetById(id);
            var response = _mapper.ConvertToDto(result);
            return response;
        }

        // POST
        [HttpPost]
        public void Post([FromBody] CarDto value)
        {
            var car = _mapper.ConvertToCar(value);
            _carRepository.Add(car);
        }

        // PUT
        [HttpPut]
        public void Put([FromBody] CarDto value)
        {
            var customer = _mapper.ConvertToCar(value);
            _carRepository.Update(customer);
        }

        // DELETE
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //_carRepository.RemoveById(id);
        }
    }
}

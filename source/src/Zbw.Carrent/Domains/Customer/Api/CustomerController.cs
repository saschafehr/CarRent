using Microsoft.AspNetCore.Mvc;
using Zbw.Carrent.Domains.Customer.Infrastructure;
using Zbw.Carrent.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zbw.Carrent.Domains.Customer.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerRepository _customerRepository;
        private CustomerMapper _mapper;

        public CustomerController(ApplicationContext context)
        {
            _customerRepository = new CustomerRepository(context);
            _mapper = new CustomerMapper();
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<CustomerResponse> Get()
        {
            var result = _customerRepository.GetAll();
            foreach (var item in result)
            {
                var response = _mapper.ConvertToResponse(item);
                yield return response;
            }
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public CustomerResponse Get(int id)
        {
            var result = _customerRepository.GetById(id);
            var response = _mapper.ConvertToResponse(result);
            return response;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerRequest value)
        {
            var customer = _mapper.ConvertToCustomer(value);
            _customerRepository.Add(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public void Put([FromBody] CustomerRequest value)
        {
            var customer = _mapper.ConvertToCustomer(value);
            _customerRepository.Update(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerRepository.RemoveById(id);
        }
    }
}

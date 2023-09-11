using Zbw.Carrent.Customer.Domain.Customer;

namespace Zbw.Carrent.Customer.Infrastructure
{
    public class CustomerRepository : BaseRepository<Domain.Customer.Customer>, ICustomerRepository
    {
        private readonly List<Domain.Customer.Customer> _customers;
        private readonly ApplicationContext _context;

        public CustomerRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public void RemoveById(int id)
        {
            var result = _context.Find<Domain.Customer.Customer>(id);
            if(result != null)
                base.Delete(result);
        }
    }
}

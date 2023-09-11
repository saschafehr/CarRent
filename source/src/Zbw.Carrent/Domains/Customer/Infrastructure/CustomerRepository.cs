using Zbw.Carrent.Shared;

namespace Zbw.Carrent.Domains.Customer.Infrastructure
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly ApplicationContext _context;

        public CustomerRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public void RemoveById(int id)
        {
            var result = _context.Find<Customer>(id);
            if (result != null)
                Delete(result);
        }
    }
}

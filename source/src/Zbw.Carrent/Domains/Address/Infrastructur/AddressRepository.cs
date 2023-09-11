using Zbw.Carrent.Shared;

namespace Zbw.Carrent.Domains.Address.Infrastructur
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

using Zbw.Carrent.Shared;

namespace Zbw.Carrent.Domains.Car.Infrastructur
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        private readonly ApplicationContext _context;
        public CarRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}

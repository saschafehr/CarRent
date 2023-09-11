using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.Customer.Infrastructure;

namespace Zbw.Carrent
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ApplicationContext _context;
        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            try
            {
                using (_context)
                {
                    _context.Add(entity);
                    _context.SaveChanges();
                }
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public void Clear()
        {
            using (_context)
            {
                _context.Customers.ExecuteDelete();
                _context.SaveChanges();
            }
        }

        public void Delete(T enitity)
        {
            using (_context)
            {
                _context.Remove<T>(enitity);
                _context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            List<T> entityList = new List<T>();

            using (_context)
            {
                _context.Set<T>()
                    .ToList()
                    .ForEach(entity => entityList.Add(entity));
            }
            return entityList;
        }

        public T GetById(int id)
        {
            using (_context)
            {
                var entity = _context.Find<T>(id);
                return entity;
            }
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
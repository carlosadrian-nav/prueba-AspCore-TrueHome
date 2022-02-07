using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Interfaces;

namespace TrueHome.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private TrueHomeContext _context;
        public PropertyRepository(TrueHomeContext context)
        {
            this._context = context;
        }
        public void Add(Property entity)
        {
            _context.Properties.Add(entity);
        }

        public Property Delete(Property entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Property> GetAll(Property entity)
        {
            throw new NotImplementedException();
        }

        public Property GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Property Update(Property entity)
        {
            throw new NotImplementedException();
        }
    }
}

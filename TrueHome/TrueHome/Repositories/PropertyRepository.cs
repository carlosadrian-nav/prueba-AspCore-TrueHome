using Microsoft.EntityFrameworkCore;
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
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdateAt = DateTime.UtcNow;

            _context.Properties.Add(entity);
        }

        public Property Delete(Property entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Property> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Property> GetById(int id)
        {
            return await _context
                    .Properties
                    .Where(w => w.Id == id)
                    .FirstOrDefaultAsync();
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

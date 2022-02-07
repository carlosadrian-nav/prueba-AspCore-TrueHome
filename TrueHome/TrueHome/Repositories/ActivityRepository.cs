using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Interfaces;

namespace TrueHome.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private TrueHomeContext _context;
        public ActivityRepository(
            TrueHomeContext context)
        {
            this._context = context;
        }

        public void Add(Activity entity)
        {
            _context.Activities.Add(entity);
        }

        public Activity Delete(Activity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll(Activity entity)
        {
            throw new NotImplementedException();
        }

        public Activity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Activity Update(Activity entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

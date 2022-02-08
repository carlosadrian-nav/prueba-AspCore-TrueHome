using Microsoft.EntityFrameworkCore;
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
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdateAt = DateTime.UtcNow;

            _context.Activities.Add(entity);
        }

        public Activity Delete(Activity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Activity> GetAll()
        {
            return _context
                        .Activities
                        .Include(i => i.Property).IgnoreAutoIncludes();
        }

        public async Task<Activity> GetById(int id)
        {
            return await _context
                        .Activities
                        .SingleOrDefaultAsync(x => x.Id == id);
        }

        public Activity Update(Activity entity)
        {
            entity.UpdateAt = DateTime.UtcNow;
            _context.Activities.Update(entity);
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Activity GetByTimeAndPoperty(int property, DateTime schedule)
        {
            var listActivities = _context
                                    .Activities
                                    .Where(w => w.Property.Id == property &&
                                            w.Schedule.AddHours(1) <= schedule &&
                                            w.Schedule.Date == schedule.Date)
                                    .FirstOrDefault();
            return listActivities;
                                    
        }
    }
}

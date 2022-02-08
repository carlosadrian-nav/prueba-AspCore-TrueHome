using TrueHome.Entities;

namespace TrueHome.Interfaces
{
    public interface IActivityRepository : IRepositoryBase<Activity>
    {
        Activity GetByTimeAndPoperty(int property, DateTime schedule);
    }
}

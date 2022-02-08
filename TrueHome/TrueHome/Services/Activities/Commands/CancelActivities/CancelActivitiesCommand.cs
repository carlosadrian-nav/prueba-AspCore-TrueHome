using TrueHome.Entities;
using TrueHome.Interfaces;

namespace TrueHome.Services.Activities.Commands.CancelActivities
{
    public class CancelActivitiesCommand
    {
        private readonly IActivityRepository _repository;

        public CancelActivitiesCommand(IActivityRepository repository)
        {
            this._repository = repository;
        }

        public async Task<bool> CancelActivity(int id)
        {
            try
            {
                var activity = await _repository.GetById(id);

                if (activity == null)
                    throw new ArgumentException("Actividad no encontrada", nameof(Activity));

                activity.StatudId = Enums.StatusType.Canceled;
                activity.Status = Enums.StatusType.Canceled.ToString();

                _repository.Update(activity);
                _repository.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

    }
}

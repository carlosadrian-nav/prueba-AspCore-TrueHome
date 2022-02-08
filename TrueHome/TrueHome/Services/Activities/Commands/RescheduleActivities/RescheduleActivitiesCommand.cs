using TrueHome.Interfaces;

namespace TrueHome.Services.Activities.Commands.RescheduleActivities
{
    public class RescheduleActivitiesCommand
    {
        private readonly IActivityRepository _repository;
        public RescheduleActivitiesCommand(
            IActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> ReScheduleAcivity(RescheduleDto entity)
        {
            try
            {
                var activity = await _repository.GetById(entity.Id);
                if (activity == null)
                    throw new ArgumentException("Actividad no encontrada", nameof(entity.Id));


                if (activity.StatudId == Enums.StatusType.Canceled)
                    throw new ArgumentException("No se puede reagendar si la actividad se encuentra cancelada", nameof(entity.Id));

                activity.Schedule = entity.Schedule;

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

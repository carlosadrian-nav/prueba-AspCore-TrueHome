using TrueHome.Entities;
using TrueHome.Enums;
using TrueHome.Interfaces;

namespace TrueHome.Services.Activities.Commands.RegisterActivities
{
    public class RegisterActivitiesCommand
    {
        private readonly IActivityRepository _repository;
        private readonly IPropertyRepository _propertyRepository;

        public RegisterActivitiesCommand(
            IActivityRepository repository,
            IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
            _repository = repository;
        }

        public async Task<int> RegisterActivity(ActivityDto entity)
        {
            var property = await _propertyRepository.GetById(entity.PropertyId);

            var activity = new Activity(
                entity.Schedule, 
                entity.Title,               
                ((StatusType)entity.StatusId).ToString(),
                (StatusType)entity.StatusId,
                property
                );

            _repository.Add(activity);
            
            _repository.SaveChanges();
            return activity.Id;

        }
    }
}

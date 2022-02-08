using FluentValidation;
using TrueHome.Enums;
using TrueHome.Interfaces;

namespace TrueHome.Services.Activities.Commands.RegisterActivities
{
    public class RegisterActivitiesValidator : AbstractValidator<ActivityDto>
    {
        private readonly IActivityRepository _repository;
        private readonly IPropertyRepository _propertyRepository;
        public RegisterActivitiesValidator(
            IActivityRepository repository, 
            IPropertyRepository propertyRepository)
        {
            _repository = repository;
            _propertyRepository = propertyRepository;

            RuleFor(x => x.StatusId).NotNull().WithMessage("StatusId no es posible ser nulo");
            
            _ = RuleFor(x => x.PropertyId).MustAsync(
                    async (PropertyId, CancellationToken) => await ValidStatusProperty(PropertyId)).WithMessage("La propiedad esa desactivada");
            
            RuleFor(x => x).Must(this.validSchedureDate).WithMessage("La propiedad esta desactivada");
        }

        private async Task<bool> ValidStatusProperty(int idProperty)
        {
            var activity = await _propertyRepository.GetById(idProperty);
            return activity.StatudId != StatusType.Canceled;

        }

        private bool validSchedureDate(ActivityDto entity)
        {
            var acvity = _repository.GetByTimeAndPoperty(entity.PropertyId, entity.Schedule);
            return acvity == null;
        }

    }
}

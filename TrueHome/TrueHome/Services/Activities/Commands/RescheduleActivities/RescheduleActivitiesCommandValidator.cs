using FluentValidation;
using TrueHome.Interfaces;

namespace TrueHome.Services.Activities.Commands.RescheduleActivities
{
    public class RescheduleActivitiesCommandValidator : AbstractValidator<RescheduleDto>
    {
        public RescheduleActivitiesCommandValidator(
            IActivityRepository repository)
        {

            _ = RuleFor(x => x.Id).GreaterThan(0).WithMessage("Actividad debe ser mayor a 0").NotNull().WithMessage("La actividad es obligatoria");
            _ = RuleFor(x => x.Schedule).NotNull().WithMessage("Debe añadir una fecha");

        }
    }
}

using FluentValidation;
using TrueHome.Entities;

namespace TrueHome.Services.Activities.Commands.RegisterActivities
{
    public class RegisterActivitiesValidator : AbstractValidator<Activity>
    {
        public RegisterActivitiesValidator()
        {
            RuleFor(x => x.Status).NotEmpty().WithMessage(x => x.Status);   

        }
    }
}

using FluentValidation;
using NetCore_TDD.Infra.Models;


namespace NetCore_TDD.Infra.Validations
{
    public class PostInsuranceValidator : AbstractValidator<Insurance>
    {
        public PostInsuranceValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .MaximumLength(20);
        }
    }
}

using FluentValidation;
using Md.Shared.Model.Info;
using Md.Shared.Validator.Url;

namespace Md.Shared.Validator.Info
{
    public class ImagesValidator : AbstractValidator<ImageList>
    {
        public ImagesValidator()
        {
            RuleFor(i => i.Urls)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();
            RuleForEach(i => i.Urls)
                .NotEmpty()
                .SetValidator(new UrlValidator())
                .WithMessage("Needs to be valid Uri");
        }
    }
}
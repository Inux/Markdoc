using FluentValidation;
using Md.Shared.Model.Contact;

namespace Md.Shared.Validator.Contact
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a).NotNull();
            RuleFor(a => a.Street).NotEmpty().WithMessage("Street must not be empty");
            RuleFor(a => a.HouseNumber).NotEmpty().WithMessage("HouseNumber must not be empty");
            RuleFor(a => a.ZipCode).NotEmpty().WithMessage("ZipCode must not be empty");
            RuleFor(a => a.Country).NotEmpty().WithMessage("Country must not be empty");
        }
    }
}
using FluentValidation;
using Md.Shared.Model.Contact;
using Md.Shared.Validator.Url;

namespace Md.Shared.Validator.Contact
{
    public class ContactValidator : AbstractValidator<ContactInfo>
    {
        public ContactValidator()
        {
            RuleFor(c => c.Address)
                .SetValidator(new AddressValidator())
                .WithMessage("Address is not valid");

            RuleFor(c => c.Mail)
                .EmailAddress().WithMessage("Email is not valid");

            RuleFor(c => c.Phone)
                .NotEmpty().WithMessage("Phone number is not valid");

            RuleFor(c => c.Web)
                .SetValidator(new UrlValidator()).WithMessage("Url is not valid");

            RuleFor(c => c.SocialMedia)
                .Must(ValidSocialMediaInfo).WithMessage("Social media information is not valid");
        }

        public bool ValidSocialMediaInfo(SocialMedia socialMedia)
        {
            return socialMedia.Facebook != ""
                   || socialMedia.Instagram != ""
                   || socialMedia.Pinterest != ""
                   || socialMedia.Twitter != ""
                   || socialMedia.Youtube != ""
                   || socialMedia.TikTok != "";
        }
    }
}
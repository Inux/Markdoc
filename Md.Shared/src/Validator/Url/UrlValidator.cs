using System;
using FluentValidation;

namespace Md.Shared.Validator.Url
{
    public class UrlValidator : AbstractValidator<string>
    {
        public UrlValidator()
        {
            RuleFor(s => s).Must(ValidUrl).WithMessage("Must be valid Url");
        }

        private static bool ValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute)
                   && url.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
        }
    }
}
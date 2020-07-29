using Md.Shared.Model.Contact;
using Md.Shared.Validator.Contact;
using Xunit;

#pragma warning disable

namespace Md.Shared.Test.Validator.Contact
{
    public class ContactInfoValidatorTest
    {
        private enum BootstrapLevel
        {
            NoAddress,
            NoMail,
            NoPhone,
            NoSocialMedia,
            NoWeb,
            Complete
        }

        private static ContactInfo BootstrapContactInfo(BootstrapLevel bsLevel)
        {
            var addr = new Address("Street", "1", "6000", "CH");
            var mail = "info@whathedrink.com";
            var phone = "0798765432";
            var socialMedia = new SocialMedia("whathedrink", "whathedrink", "whathedrink", "whathedrink", "whathedrink",
                "whathedrink");
            var web = "https://www.whathedrink.com";

            switch (bsLevel)
            {
                case BootstrapLevel.NoAddress:
                    addr = new Address("Street", "1", "6000", "");
                    break;
                case BootstrapLevel.NoMail:
                    mail = "";
                    break;
                case BootstrapLevel.NoPhone:
                    phone = "";
                    break;
                case BootstrapLevel.NoSocialMedia:
                    socialMedia = new SocialMedia("", "", "", "", "", "");
                    break;
                case BootstrapLevel.NoWeb:
                    web = "";
                    break;
                case BootstrapLevel.Complete:
                default:
                    break;
            }

            return new ContactInfo(addr, mail, phone, socialMedia, web);
        }

        [Fact]
        public void MissingAddressLeadsToInvalidContactInfo()
        {
            var ci = BootstrapContactInfo(BootstrapLevel.NoAddress);
            Assert.False(new ContactValidator().Validate(ci).IsValid);
        }

        [Fact]
        public void MissingMailLeadsToInvalidContactInfo()
        {
            var ci = BootstrapContactInfo(BootstrapLevel.NoMail);
            Assert.False(new ContactValidator().Validate(ci).IsValid);
        }

        [Fact]
        public void MissingPhoneLeadsToInvalidContactInfo()
        {
            var ci = BootstrapContactInfo(BootstrapLevel.NoPhone);
            Assert.False(new ContactValidator().Validate(ci).IsValid);
        }

        [Fact]
        public void MissingSocialMediaLeadsToInvalidContactInfo()
        {
            var ci = BootstrapContactInfo(BootstrapLevel.NoSocialMedia);
            Assert.False(new ContactValidator().Validate(ci).IsValid);
        }

        [Fact]
        public void MissingWebLeadsToInvalidContactInfo()
        {
            var ci = BootstrapContactInfo(BootstrapLevel.NoWeb);
            Assert.False(new ContactValidator().Validate(ci).IsValid);
        }

        [Fact]
        public void ValidDataLeadsToValidContactInfo()
        {
            var ci = BootstrapContactInfo(BootstrapLevel.Complete);
            Assert.True(new ContactValidator().Validate(ci).IsValid);
        }
    }
}

#pragma warning restore
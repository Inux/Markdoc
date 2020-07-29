using Md.Shared.Model.Contact;
using Md.Shared.Validator.Contact;
using Xunit;

#pragma warning disable

namespace Md.Shared.Test.Validator.Contact
{
    public class AddressValidatorTest
    {
        public static Address GetAddress(bool street, bool number, bool code, bool country)
        {
            return new Address(
                street ? "Street" : null,
                number ? "1" : null,
                code ? "6000" : null,
                country ? "CH" : null
            );
        }

        [Fact]
        public void CorrectAddressLeadsToValidResult()
        {
            var addr = GetAddress(true, true, true, true);
            Assert.True(new AddressValidator().Validate(addr).IsValid);
        }

        [Fact]
        public void MissingCountryLeadsToInvalidAddress()
        {
            var addr = GetAddress(true, true, true, false);
            Assert.False(new AddressValidator().Validate(addr).IsValid);
        }

        [Fact]
        public void MissingHouseNumberLeadsToInvalidAddress()
        {
            var addr = GetAddress(true, false, true, true);
            Assert.False(new AddressValidator().Validate(addr).IsValid);
        }

        [Fact]
        public void MissingStreetLeadsToInvalidAddress()
        {
            var addr = GetAddress(false, true, true, true);
            Assert.False(new AddressValidator().Validate(addr).IsValid);
        }

        [Fact]
        public void MissingZipCodeLeadsToInvalidAddress()
        {
            var addr = GetAddress(true, true, false, true);
            Assert.False(new AddressValidator().Validate(addr).IsValid);
        }
    }
}

#pragma warning restore
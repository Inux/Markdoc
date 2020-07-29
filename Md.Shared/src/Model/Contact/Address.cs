using System;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Contact
{
    [Serializable]
    public class Address : Unique
    {
        public Address(string street, string houseNumber, string zipCode, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
            Country = country;
        }

        [Index("Address", 1, IsUnique = true)]
        public string Street { get; set; }

        [Index("Address", 2, IsUnique = true)]
        public string HouseNumber { get; set; }

        [Index("Address", 3, IsUnique = true)]
        public string ZipCode { get; set; }

        [Index("Address", 4, IsUnique = true)]
        public string Country { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Street)}: {Street}, {nameof(HouseNumber)}: {HouseNumber}, {nameof(ZipCode)}: {ZipCode}, {nameof(Country)}: {Country}";
        }
    }
}
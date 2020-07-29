using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Model.Bars;
using Md.Shared.Model.Base;
using Md.Shared.Model.Contact;

namespace Md.Shared.Model.Crowd
{
    [Serializable]
    public class Crowd : Unique
    {
        public Crowd()
        {

        }

        public Crowd(string name, ContactInfo contact, List<Bar> bars)
        {
            Name = name;
            Contact = contact;
            Bars = bars;
        }

        [Index("Crowd", 1, IsUnique = true)]
        public string Name { get; set; } = null!;

        public ContactInfo Contact { get; set; } = null!;
        public List<Bar> Bars { get; set; } = null!;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Contact)}: {Contact}, {nameof(Bars)}: {Bars}";
        }
    }
}
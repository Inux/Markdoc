using System;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Drinks
{
    [Serializable]
    public class DrinkUnit : Unique
    {
        public DrinkUnit(string name, uint milliLiter)
        {
            Name = name;
            MilliLiter = milliLiter;
        }

        [Index("DrinkUnit", 1, IsUnique = true)]
        public string Name { get; set; }
        public uint MilliLiter { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(MilliLiter)}: {MilliLiter.ToString()}";
        }
    }
}

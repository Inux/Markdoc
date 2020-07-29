using System;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Drinks
{
    [Serializable]
    public class Ingredient : Unique
    {
        public Ingredient(string name)
        {
            Name = name;
        }

        [Index("Ingredient", 1, IsUnique = true)]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id.ToString()}, {nameof(Name)}: {Name}";
        }
    }
}
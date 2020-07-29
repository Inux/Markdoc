using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Drinks
{
    [Serializable]
    public class DrinkGroup : Unique
    {
        public DrinkGroup()
        {

        }

        public DrinkGroup(string name, string description, DrinkGroup? parent = null, DrinkGroup? child = null,
            List<Drink>? drinks = null)
        {
            Name = name;
            Description = description;
            Parent = parent;
            Child = child;
            Drinks = drinks;
        }

        [Index("DrinkGroup", 1, IsUnique = true)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        [ForeignKey("parentDrinkGroup")]
        public DrinkGroup? Parent { get; set; }

        [ForeignKey("childDrinkGroup")]
        public DrinkGroup? Child { get; set; }
        public List<Drink>? Drinks { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Parent)}: {Parent}, {nameof(Child)}: {Child}, {nameof(Drinks)}: {Drinks}";
        }
    }
}
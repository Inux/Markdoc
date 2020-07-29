using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Lib;
using Md.Shared.Model.Base;
using Md.Shared.Model.Info;
using Md.Shared.Model.Tags;

namespace Md.Shared.Model.Drinks
{
    [Serializable]
    public class Drink : Unique
    {
        public Drink()
        {

        }

        public Drink(string name, string description, ImageList imageList, List<Tag> tags,
            List<DrinkUnit> units)
        {
            Name = name;
            Description = description;
            ImageList = imageList;
            Tags = tags;
            Units = units;
        }

        [Index("Drink", 1, IsUnique = true)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public ImageList ImageList { get; set; } = null!;
        public List<Tag> Tags { get; set; } = null!;
        public List<DrinkUnit> Units { get; set; } = null!;

        public override string ToString()
        {
            return
                $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(ImageList)}: {ImageList}, {nameof(Tags)}: {Format.ToString(Tags)}, {nameof(Units)}: {Format.ToString(Units)}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Lib;
using Md.Shared.Model.Base;
using Md.Shared.Model.Contact;
using Md.Shared.Model.Drinks;
using Md.Shared.Model.Info;
using Md.Shared.Model.Tags;

namespace Md.Shared.Model.Bars
{
    [Serializable]
    public class Bar : Unique
    {
        public Bar()
        {

        }

        public Bar(string name, string description, ImageList imageList, ContactInfo contact, List<Tag> tags,
            List<DrinkGroup> drinkGroups)
        {
            Name = name;
            Description = description;
            ImageList = imageList;
            Contact = contact;
            Tags = tags;
            DrinkGroups = drinkGroups;
        }

        [Index("IndexBar", 1, IsUnique = true)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public ImageList ImageList { get; set; } = null!;
        public ContactInfo Contact { get; set; } = null!;
        public List<Tag> Tags { get; set; } = null!;
        public List<DrinkGroup> DrinkGroups { get; set; } = null!;

        public override string ToString()
        {
            return
                $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(ImageList)}: {ImageList}, {nameof(Contact)}: {Contact}, {nameof(Tags)}: {Format.ToString(Tags)}, {nameof(DrinkGroups)}: {DrinkGroups}";
        }
    }
}
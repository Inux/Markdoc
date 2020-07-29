using System;
using System.ComponentModel.DataAnnotations.Schema;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Tags
{
    [Serializable]
    public class Tag : Unique
    {
        public Tag()
        {
        }

        public Tag(string name)
        {
            Name = name;
        }

        [Index("Tag", 1, IsUnique = true)]
        public string Name { get; set; } = "";

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id.ToString()}, {nameof(Name)}: {Name}";
        }
    }
}
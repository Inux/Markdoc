using System;
using System.ComponentModel.DataAnnotations;

namespace Md.Shared.Model.Base
{
    [Serializable]
    public class Unique
    {
        protected Unique()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
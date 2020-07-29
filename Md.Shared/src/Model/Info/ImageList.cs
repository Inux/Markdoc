using System;
using System.Collections.Generic;
using Md.Shared.Lib;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Info
{
    [Serializable]
    public class ImageList : Unique
    {
        public ImageList()
        {
        }

        public ImageList(List<string> urls)
        {
            Urls = urls;
        }

        public List<string> Urls { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id.ToString()}, {nameof(Urls)}: {Format.ToString(Urls)}";
        }
    }
}
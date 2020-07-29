using System;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Contact
{
    [Serializable]
    public class SocialMedia : Unique
    {
        public SocialMedia(string? instagram, string? pinterest, string? youtube, string? facebook, string? twitter,
            string? tikTok)
        {
            Instagram = instagram;
            Pinterest = pinterest;
            Youtube = youtube;
            Facebook = facebook;
            Twitter = twitter;
            TikTok = tikTok;
        }

        public string? Instagram { get; set; }
        public string? Pinterest { get; set; }
        public string? Youtube { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? TikTok { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Instagram)}: {Instagram}, {nameof(Pinterest)}: {Pinterest}, {nameof(Youtube)}: {Youtube}, {nameof(Facebook)}: {Facebook}, {nameof(Twitter)}: {Twitter}, {nameof(TikTok)}: {TikTok}";
        }
    }
}
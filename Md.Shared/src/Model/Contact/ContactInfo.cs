using System;
using Md.Shared.Model.Base;

namespace Md.Shared.Model.Contact
{
    [Serializable]
    public class ContactInfo : Unique
    {
        public ContactInfo()
        {

        }

        public ContactInfo(Address address, string mail, string phone, SocialMedia socialMedia, string web)
        {
            Address = address;
            Mail = mail;
            Phone = phone;
            SocialMedia = socialMedia;
            Web = web;
        }

        public Address Address { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public SocialMedia SocialMedia { get; set; } = null!;
        public string Web { get; set; } = null!;

        public override string ToString()
        {
            return
                $"{nameof(Address)}: {Address}, {nameof(Mail)}: {Mail}, {nameof(Phone)}: {Phone}, {nameof(SocialMedia)}: {SocialMedia}, {nameof(Web)}: {Web}";
        }
    }
}
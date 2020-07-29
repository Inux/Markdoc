using System.Collections.Generic;
using Md.Shared.Model.Info;
using Md.Shared.Validator.Info;
using Xunit;

#pragma warning disable

namespace Md.Shared.Test.Validator.Info
{
    public class ImagesValidatorTest
    {
        public static ImageList GetImages(bool format, bool https)
        {
            return (format, https) switch
            {
                (false, _) => new ImageList(new List<string> {"whaTheDrink"}),
                (_, false) => new ImageList(new List<string> {"http://whathedrink.com"}),
                _ => new ImageList(new List<string>{"https://www.whathedrink.com", "https://whathedrink.com"})
            };
        }

        [Fact]
        public void NoUrlLeadsToInvalidImages()
        {
            var images = new ImageList(null);
            Assert.False(new ImagesValidator().Validate(images).IsValid);
        }

        [Fact]
        public void ValidUrlsLeadsToValidImages()
        {
            var images = GetImages(true, true);
            Assert.True(new ImagesValidator().Validate(images).IsValid);
        }

        [Fact]
        public void WellFormattedUrlsButHttpLeadsToInvalidImages()
        {
            var images = GetImages(true, false);
            Assert.False(new ImagesValidator().Validate(images).IsValid);
        }

        [Fact]
        public void WrongFormattedUrlsLeadsToInvalidImages()
        {
            var images = GetImages(false, true);
            Assert.False(new ImagesValidator().Validate(images).IsValid);
        }
    }
}

#pragma warning restore
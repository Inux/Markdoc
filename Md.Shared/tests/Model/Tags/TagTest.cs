using Md.Shared.Model.Tags;
using Xunit;

namespace Md.Shared.Test.Model.Tags
{
    public class TagTest
    {
        [Fact]
        public void CreateTagAndCheckStringFormatting()
        {
            var name = "MD";
            Tag tag = new Tag(name);

            var expected = $"{nameof(Tag.Id)}: {tag.Id.ToString()}, {nameof(Tag.Name)}: {name}";
            Assert.Equal(expected, tag.ToString());
        }
    }
}
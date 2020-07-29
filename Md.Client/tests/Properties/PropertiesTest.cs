using Md.Client.Properties.Layout;
using Xunit;

namespace Md.Client.Properties.Test
{
    public class PropertiesTests
    {
        [Fact]
        public void CheckThatBgColorIsCorrect()
        {
            Assert.Equal("bg-gray-200", Bg.Main);
        }
    }
}
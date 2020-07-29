using System.Collections.Generic;
using Md.Shared.Lib;
using Xunit;

namespace Md.Shared.Test.Lib
{
    public class FormatTest
    {
        [Fact]
        public void CheckToStringWithEnumerable()
        {
            const string expected = "A, B, C";

            var enumerable = new List<string> {"A", "B", "C"};
            var result = Format.ToString(enumerable);

            Assert.Equal(expected, result);
        }
    }
}
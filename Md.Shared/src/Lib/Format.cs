using System.Collections.Generic;

namespace Md.Shared.Lib
{
    public class Format
    {
        public static string ToString<T>(IEnumerable<T> enumerable)
        {
            return string.Join(", ", enumerable);
        }
    }
}
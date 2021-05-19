using System.Linq;

namespace ObjectPrinter.Utilities
{
    internal static class StringExtensions
    {
        internal static string Repeat(this string value, int times)
        {
            return Enumerable.Repeat(value, times).JoinToString("");
        }
    }
}
using System;
using System.Globalization;

namespace IQFeed.CSharpApiClient.Extensions
{
    public static class NullableExtensions
    {
        public static string ToInvariantString(this DateTime? date, string format)
        {
            return date.HasValue ? date.Value.ToString(format, CultureInfo.InvariantCulture) : string.Empty;
        }
    }
}
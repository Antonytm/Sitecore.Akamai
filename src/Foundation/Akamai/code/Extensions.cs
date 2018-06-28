using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Akamai
{
    public static class Extensions
    {
        public static Dictionary<string, string> ParseAkamaiHeader(this string headerValue)
        {
            var pairs = headerValue.Split(',').Select(x => x.Trim());
            var dictionary = new Dictionary<string, string>();
            foreach (var pair in pairs)
            {
                var parts = pair.Split('=');
                if (parts.Length > 1)
                {
                    var key = parts[0];
                    var value = parts[1];
                    dictionary.Add(key, value);
                }
            }

            return dictionary;
        }
    }
}

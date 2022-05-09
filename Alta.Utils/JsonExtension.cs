using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alta.Utils
{
    public static class JsonExtension
    {
        public static string ToJson<T>(this T t)
        {
            return JsonSerializer.Serialize(t);
        }

        public static T FromJson<T>(this string s)
        {
            return JsonSerializer.Deserialize<T>(s);
        }

    }
}

using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace StateManagementDemo.Models
{
    public static class TempDataExtension
    {
        public static void Put<T>(this ITempDataDictionary tempdata,
            string key, T value)
        {
            tempdata[key] = JsonConvert.SerializeObject(value);
        }

        public static T Get<T>(this ITempDataDictionary tempdata, 
            string key)
        {
            tempdata.TryGetValue(key, out var o);
            return o == null ? default(T) : JsonConvert.
                DeserializeObject<T>((string)o);
        }
    }
}

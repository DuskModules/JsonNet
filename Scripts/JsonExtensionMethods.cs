using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace DuskModules.JsonNet {

  /// <summary> Extension methods for JSON use </summary>
  public static class JsonExtensionMethods {

    /// <summary> Converts the object to JSON compatible text </summary>
    /// <param name="o"> The serializable object to convert </param>
    /// <returns> The JSON string </returns>
    public static string ToJsonText<T>(this T o) {
      return JsonConvert.SerializeObject(o, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
    }

    /// <summary> Converts the text to an object of the given type </summary>
    /// <typeparam name="T"> The type to use </typeparam>
    /// <param name="s"> The json text value </param>
    /// <returns> The deserialized object </returns>
    public static T ToJsonObject<T>(this string s) {
      return JsonConvert.DeserializeObject<T>(s, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
    }

  }
}
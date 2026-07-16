using System;
using System.Collections.Generic;
using MusicKeys.Enums;
using MusicKeys.Attributes;

namespace MusicKeys.Extensions
{
 /// <summary>
 /// Extension methods for <see cref="MusicKey"/> providing short name, long name, and mode helpers.
 /// </summary>
 public static class MusicKeyExtensions
 {
 // Cache attributes to avoid repeated reflection lookups and keep the API fast and simple.
 private static readonly Lazy<Dictionary<MusicKey, MusicKeyDescriptionAttribute>> s_attrCache =
 new Lazy<Dictionary<MusicKey, MusicKeyDescriptionAttribute>>(BuildCache);

 /// <summary>
 /// Gets the short name for a given musical key (for example: "C#").
 /// </summary>
 /// <param name="key">The musical key.</param>
 /// <returns>The short name if available; otherwise <see cref="Enum.ToString()"/> value.</returns>
 public static string GetShortName(this MusicKey key)
 {
 var attr = GetAttribute(key);
 return attr?.ShortName ?? key.ToString();
 }

 /// <summary>
 /// Gets the long, human-readable name for a given musical key (for example: "C# major").
 /// </summary>
 /// <param name="key">The musical key.</param>
 /// <returns>The long name if available; otherwise <see cref="Enum.ToString()"/> value.</returns>
 public static string GetLongName(this MusicKey key)
 {
 var attr = GetAttribute(key);
 return attr?.LongName ?? key.ToString();
 }

 /// <summary>
 /// Indicates whether the key is in the major mode.
 /// </summary>
 /// <param name="key">The musical key.</param>
 /// <returns><c>true</c> if the key is major; otherwise, <c>false</c>.</returns>
 public static bool IsMajor(this MusicKey key)
 {
 var attr = GetAttribute(key);
 return attr?.IsMajor ?? false;
 }

 private static MusicKeyDescriptionAttribute GetAttribute(MusicKey key)
 {
 MusicKeyDescriptionAttribute attr;
 return s_attrCache.Value.TryGetValue(key, out attr) ? attr : null;
 }

 private static Dictionary<MusicKey, MusicKeyDescriptionAttribute> BuildCache()
 {
 var dict = new Dictionary<MusicKey, MusicKeyDescriptionAttribute>();
 var type = typeof(MusicKey);
 foreach (var name in Enum.GetNames(type))
 {
 var field = type.GetField(name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
 if (field == null) continue;
 var attr = (MusicKeyDescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(MusicKeyDescriptionAttribute));
 MusicKey parsed;
 if (attr != null && Enum.TryParse(name, out parsed))
 {
 dict[parsed] = attr;
 }
 }
 return dict;
 }
 }
}

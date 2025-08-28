using System;
using MusicKeys.Enums;
using MusicKeys.Attributes;

namespace MusicKeys.Extensions
{
    /// <summary>
    /// Extension methods for MusicKey: return short name, long name, and major/minor mode.
    /// </summary>
    public static class MusicKeyExtensions
    {
        public static string GetShortName(this MusicKey key)
        {
            var attr = GetAttribute(key);
            return attr?.ShortName ?? key.ToString();
        }

        public static string GetLongName(this MusicKey key)
        {
            var attr = GetAttribute(key);
            return attr?.LongName ?? key.ToString();
        }

        public static bool IsMajor(this MusicKey key)
        {
            var attr = GetAttribute(key);
            return attr?.IsMajor ?? false;
        }

        private static MusicKeyDescriptionAttribute? GetAttribute(MusicKey key)
        {
            var field = key.GetType().GetField(key.ToString());
            return field != null ? (MusicKeyDescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(MusicKeyDescriptionAttribute)) : null;
        }
    }
}

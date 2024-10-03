using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicKeys
{
    /// <summary>
    /// Extension of the Key class with methods returning the short name, full name, and information whether it is a major key.
    /// </summary>
    public static class KeyExtensions
    {
        public static string GetShortName(this MusicKey key)
        {
            var field = key.GetType().GetField(key.ToString());
            if (field == null) return key.ToString();
            var attribute = (KeyDescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(KeyDescriptionAttribute));
            return attribute == null ? key.ToString() : attribute.ShortName;
        }

        public static string GetLongName(this MusicKey key)
        {
            var field = key.GetType().GetField(key.ToString());
            if (field == null) return key.ToString();
            var attribute = (KeyDescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(KeyDescriptionAttribute));
            return attribute == null ? key.ToString() : attribute.LongName;
        }

        public static bool IsMajor(this MusicKey key)
        {
            var field = key.GetType().GetField(key.ToString());
            if (field == null) return false;
            var attribute = (KeyDescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(KeyDescriptionAttribute));
            return attribute != null && attribute.IsMajor;
        }
    }
}

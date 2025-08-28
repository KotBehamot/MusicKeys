using System;

namespace MusicKeys
{
    /// <summary>
    /// Attribute describing a musical key (short name, full name, major/minor mode).
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class KeyDescriptionAttribute : Attribute
    {
        public string ShortName { get; }
        public string LongName { get; }
        public bool IsMajor { get; }

        public KeyDescriptionAttribute(string shortName, string longName, bool isMajor)
        {
            ShortName = shortName;
            LongName = longName;
            IsMajor = isMajor;
        }
    }
}

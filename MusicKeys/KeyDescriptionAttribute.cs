using System;

namespace MusicKeys.Attributes
{
    /// <summary>
    /// Attribute describing a musical key (short name, full name, major/minor mode).
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class MusicKeyDescriptionAttribute : Attribute
    {
        public string ShortName { get; }
        public string LongName { get; }
        public bool IsMajor { get; }

        public MusicKeyDescriptionAttribute(string shortName, string longName, bool isMajor)
        {
            ShortName = shortName;
            LongName = longName;
            IsMajor = isMajor;
        }
    }
}

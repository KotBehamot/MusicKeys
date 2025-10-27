using System;

namespace MusicKeys.Attributes
{
    /// <summary>
    /// Attribute describing a musical key. Provides a short name, a long display name, and mode information.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class MusicKeyDescriptionAttribute : Attribute
    {
        /// <summary>
        /// Gets the short name of the key (for example: "C#").
        /// </summary>
        public string ShortName { get; }

        /// <summary>
        /// Gets the long, human-readable name of the key (for example: "C# major").
        /// </summary>
        public string LongName { get; }

        /// <summary>
        /// Gets a value indicating whether the key is major. If false, the key is minor.
        /// </summary>
        public bool IsMajor { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicKeyDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="shortName">Short name of the key, e.g., "C#".</param>
        /// <param name="longName">Long, human-readable key name, e.g., "C# major".</param>
        /// <param name="isMajor">True if the key is major; otherwise false (minor).</param>
        public MusicKeyDescriptionAttribute(string shortName, string longName, bool isMajor)
        {
            ShortName = shortName;
            LongName = longName;
            IsMajor = isMajor;
        }
    }
}

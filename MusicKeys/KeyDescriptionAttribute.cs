using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicKeys
{
    /// <summary>
    /// atrybut opisujący tonację muzyczną 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class KeyDescriptionAttribute : Attribute
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

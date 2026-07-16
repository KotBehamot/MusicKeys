using MusicKeys.Attributes;

namespace MusicKeys.Enums
{
    /// <summary>
    /// Enum representing musical keys with descriptive attributes.
    /// </summary>
    public enum MusicKey
    {
        /// <summary>
        /// C major key
        /// </summary>
        [MusicKeyDescription("C", "C major", true)] CMajor,
        /// <summary>
        /// C# major key
        /// </summary>
        [MusicKeyDescription("C#", "C# major", true)] CSharpMajor,
        /// <summary>
        /// D major key
        /// </summary>
        [MusicKeyDescription("D", "D major", true)] DMajor,
        /// <summary>
        /// D# major key
        /// </summary>
        [MusicKeyDescription("D#", "D# major", true)] DSharpMajor,
        /// <summary>
        /// E major key
        /// </summary>
        [MusicKeyDescription("E", "E major", true)] EMajor,
        /// <summary>
        /// F major key
        /// </summary>
        [MusicKeyDescription("F", "F major", true)] FMajor,
        /// <summary>
        /// F# major key
        /// </summary>
        [MusicKeyDescription("F#", "F# major", true)] FSharpMajor,
        /// <summary>
        /// G major key
        /// </summary>
        [MusicKeyDescription("G", "G major", true)] GMajor,
        /// <summary>
        /// G# major key
        /// </summary>
        [MusicKeyDescription("G#", "G# major", true)] GSharpMajor,
        /// <summary>
        /// A major key
        /// </summary>
        [MusicKeyDescription("A", "A major", true)] AMajor,
        /// <summary>
        /// A# major key
        /// </summary>
        [MusicKeyDescription("A#", "A# major", true)] ASharpMajor,
        /// <summary>
        /// B major key
        /// </summary>
        [MusicKeyDescription("B", "B major", true)] BMajor,
        /// <summary>
        /// Db major key
        /// </summary>
        [MusicKeyDescription("Db", "Db major", true)] DbMajor,
        /// <summary>
        /// Eb major key
        /// </summary>
        [MusicKeyDescription("Eb", "Eb major", true)] EbMajor,
        /// <summary>
        /// Gb major key
        /// </summary>
        [MusicKeyDescription("Gb", "Gb major", true)] GbMajor,
        /// <summary>
        /// Ab major key
        /// </summary>
        [MusicKeyDescription("Ab", "Ab major", true)] AbMajor,
        /// <summary>
        /// Bb major key
        /// </summary>
        [MusicKeyDescription("Bb", "Bb major", true)] BbMajor,
        /// <summary>
        /// A minor key
        /// </summary>
        [MusicKeyDescription("A", "A minor", false)] AMinor,
        /// <summary>
        /// C# minor key
        /// </summary>
        [MusicKeyDescription("C#", "C# minor", false)] CSharpMinor,
        /// <summary>
        /// D minor key
        /// </summary>
        [MusicKeyDescription("D", "D minor", false)] DMinor,
        /// <summary>
        /// D# minor key
        /// </summary>
        [MusicKeyDescription("D#", "D# minor", false)] DSharpMinor,
        /// <summary>
        /// E minor key
        /// </summary>
        [MusicKeyDescription("E", "E minor", false)] EMinor,
        /// <summary>
        /// F minor key
        /// </summary>
        [MusicKeyDescription("F", "F minor", false)] FMinor,
        /// <summary>
        /// F# minor key
        /// </summary>
        [MusicKeyDescription("F#", "F# minor", false)] FSharpMinor,
        /// <summary>
        /// G minor key
        /// </summary>
        [MusicKeyDescription("G", "G minor", false)] GMinor,
        /// <summary>
        /// G# minor key
        /// </summary>
        [MusicKeyDescription("G#", "G# minor", false)] GSharpMinor,
        /// <summary>
        /// B minor key
        /// </summary>
        [MusicKeyDescription("B", "B minor", false)] BMinor,
        /// <summary>
        /// A# minor key
        /// </summary>
        [MusicKeyDescription("A#", "A# minor", false)] ASharpMinor,
        /// <summary>
        /// C minor key
        /// </summary>
        [MusicKeyDescription("C", "C minor", false)] CMinor
    }
}

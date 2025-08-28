using MusicKeys.Attributes;

namespace MusicKeys.Enums
{
    /// <summary>
    /// Enum representing musical keys with descriptive attributes.
    /// </summary>
    public enum MusicKey
    {
        [MusicKeyDescription("C", "C major", true)] CMajor,
        [MusicKeyDescription("C#", "C# major", true)] CSharpMajor,
        [MusicKeyDescription("D", "D major", true)] DMajor,
        [MusicKeyDescription("D#", "D# major", true)] DSharpMajor,
        [MusicKeyDescription("E", "E major", true)] EMajor,
        [MusicKeyDescription("F", "F major", true)] FMajor,
        [MusicKeyDescription("F#", "F# major", true)] FSharpMajor,
        [MusicKeyDescription("G", "G major", true)] GMajor,
        [MusicKeyDescription("G#", "G# major", true)] GSharpMajor,
        [MusicKeyDescription("A", "A major", true)] AMajor,
        [MusicKeyDescription("A#", "A# major", true)] ASharpMajor,
        [MusicKeyDescription("B", "B major", true)] BMajor,
        [MusicKeyDescription("Db", "Db major", true)] DbMajor,
        [MusicKeyDescription("Eb", "Eb major", true)] EbMajor,
        [MusicKeyDescription("Gb", "Gb major", true)] GbMajor,
        [MusicKeyDescription("Ab", "Ab major", true)] AbMajor,
        [MusicKeyDescription("Bb", "Bb major", true)] BbMajor,
        [MusicKeyDescription("A", "A minor", false)] AMinor,
        [MusicKeyDescription("C#", "C# minor", false)] CSharpMinor,
        [MusicKeyDescription("D", "D minor", false)] DMinor,
        [MusicKeyDescription("D#", "D# minor", false)] DSharpMinor,
        [MusicKeyDescription("E", "E minor", false)] EMinor,
        [MusicKeyDescription("F", "F minor", false)] FMinor,
        [MusicKeyDescription("F#", "F# minor", false)] FSharpMinor,
        [MusicKeyDescription("G", "G minor", false)] GMinor,
        [MusicKeyDescription("G#", "G# minor", false)] GSharpMinor,
        [MusicKeyDescription("B", "B minor", false)] BMinor,
        [MusicKeyDescription("A#", "A# minor", false)] ASharpMinor,
        [MusicKeyDescription("C", "C minor", false)] CMinor
    }
}

namespace MusicKeys
{
    /// <summary>
    /// Enum representing musical keys with descriptive attributes.
    /// </summary>
    public enum MusicKey
    {
        [KeyDescription("C", "C major", true)] C,
        [KeyDescription("C#", "C# major", true)] CSharp,
        [KeyDescription("D", "D major", true)] D,
        [KeyDescription("D#", "D# major", true)] DSharp,
        [KeyDescription("E", "E major", true)] E,
        [KeyDescription("F", "F major", true)] F,
        [KeyDescription("F#", "F# major", true)] FSharp,
        [KeyDescription("G", "G major", true)] G,
        [KeyDescription("G#", "G# major", true)] GSharp,
        [KeyDescription("A", "A major", true)] A,
        [KeyDescription("A#", "A# major", true)] ASharp,
        [KeyDescription("B", "B major", true)] B,
        [KeyDescription("Db", "Db major", true)] Db,
        [KeyDescription("Eb", "Eb major", true)] Eb,
        [KeyDescription("Gb", "Gb major", true)] Gb,
        [KeyDescription("Ab", "Ab major", true)] Ab,
        [KeyDescription("Bb", "Bb major", true)] Bb,
        [KeyDescription("a", "A minor", false)] a,
        [KeyDescription("c#", "C# minor", false)] cSharp,
        [KeyDescription("d", "D minor", false)] d,
        [KeyDescription("d#", "D# minor", false)] dSharp,
        [KeyDescription("e", "E minor", false)] e,
        [KeyDescription("f", "F minor", false)] f,
        [KeyDescription("f#", "F# minor", false)] fSharp,
        [KeyDescription("g", "G minor", false)] g,
        [KeyDescription("g#", "G# minor", false)] gSharp,
        [KeyDescription("b", "B minor", false)] b,
        [KeyDescription("a#", "A# minor", false)] aSharp,
        [KeyDescription("c", "C minor", false)] c
    }
}

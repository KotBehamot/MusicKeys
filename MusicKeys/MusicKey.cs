namespace MusicKeys
{
    /// <summary>
    /// mapa tonacji muzycznych 
    /// </summary>
    public enum MusicKey
    {
        [KeyDescription("C", "C-dur", true)] C,
        [KeyDescription("C#", "C#-dur", true)] CSharp,
        [KeyDescription("D", "D-dur", true)] D,
        [KeyDescription("D#", "D#-dur", true)] DSharp,
        [KeyDescription("E", "E-dur", true)] E,
        [KeyDescription("F", "F-dur", true)] F,
        [KeyDescription("F#", "F#-dur", true)] FSharp,
        [KeyDescription("G", "G-dur", true)] G,
        [KeyDescription("G#", "G#-dur", true)] GSharp,
        [KeyDescription("A", "A-dur", true)] A,
        [KeyDescription("A#", "A#-dur", true)] ASharp,
        [KeyDescription("B", "B-dur", true)] B,
        [KeyDescription("Db", "Db-dur", true)] Db,
        [KeyDescription("Eb", "Eb-dur", true)] Eb,
        [KeyDescription("Gb", "Gb-dur", true)] Gb,
        [KeyDescription("Ab", "Ab-dur", true)] Ab,
        [KeyDescription("Bb", "Bb-dur", true)] Bb,
        [KeyDescription("a", "A-moll", false)] a,
        [KeyDescription("c#", "C#-moll", false)] cSharp,
        [KeyDescription("d", "D-moll", false)] d,
        [KeyDescription("d#", "D#-moll", false)] dSharp,
        [KeyDescription("e", "E-moll", false)] e,
        [KeyDescription("f", "F-moll", false)] f,
        [KeyDescription("f#", "F#-moll", false)] fSharp,
        [KeyDescription("g", "G-moll", false)] g,
        [KeyDescription("g#", "G#-moll", false)] gSharp,
        [KeyDescription("b", "B-moll", false)] b,
        [KeyDescription("a#", "A#-moll", false)] aSharp,
        [KeyDescription("c", "C-moll", false)] c
    }
}

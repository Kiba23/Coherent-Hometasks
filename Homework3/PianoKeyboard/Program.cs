using System;
using PianoKeyboard.Enums;

namespace PianoKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Key c = new Key(Notes.C, Accidentals.Sharp, Octaves.First);
            Console.WriteLine(c);

            Key d = new Key(Notes.D, Accidentals.Flat, Octaves.First);

            Console.WriteLine(c.Equals(d));
            Console.WriteLine(c.CompareTo(d));
        }
    }
}

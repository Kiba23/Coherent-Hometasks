using PianoKeyboard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoKeyboard
{
    public static class KeyHelper
    {
        private static List<(Notes Note, Accidentals Accidental)> NotExistedKeys = new List<(Notes note, Accidentals accidental)>() 
        { 
            (Notes.E, Accidentals.Sharp),
            (Notes.F, Accidentals.Flat),
            (Notes.B, Accidentals.Sharp),
            (Notes.C, Accidentals.Flat)
        };


        // Handling the case with E Sharp, F Flat, B Sharp and C Flat. This keys don't exist becuase they don't have one of the Accidentals.
        public static bool IsKeyHasWrongAccidental(Key key)
        {
            foreach (var item in NotExistedKeys)
            {
                if (item.Note == key.Note && item.Accidental == key.Accidental)
                {
                    return true;
                }
            }
            return false;
        }

        // Getting the equivalent key.
        public static Key GetSameKey(Key initKey)
        {
            var note = initKey.Accidental == Accidentals.Sharp
                ? initKey.Note + 1
                : initKey.Note - 1;
            var accidental = initKey.Accidental == Accidentals.Sharp
                ? Accidentals.Flat
                : Accidentals.Sharp;
            var octave = initKey.Octave;

            return new Key(note, accidental, octave);
        }
    }
}

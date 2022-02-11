using PianoKeyboard.Enums;
using System.Collections.Generic;

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
            #region Note
            int octaveMove = 0; // 0 - not moving
            Notes note;
            if (initKey.Accidental == Accidentals.Sharp)
            {
                if ((int)initKey.Note == 6)
                {
                    note = (Notes)0; // moving to start if reaches max number - 6
                    octaveMove++;
                }
                else
                {
                    note = initKey.Note + 1;
                }
            }
            else // case when initKey.Accidental == Accidentals.Flat
            {
                if ((int)initKey.Note == 0)
                {
                    note = (Notes)6; // moving to start if reaches min number - 0
                    octaveMove--;
                }
                else
                {
                    note = initKey.Note - 1;
                }
            }
            #endregion

            #region Accidental
            // Changing the opposite
            var accidental = initKey.Accidental == Accidentals.Sharp
                ? Accidentals.Flat
                : Accidentals.Sharp;
            #endregion

            #region Octave
            Octaves octave;
            if ((int)initKey.Octave + octaveMove == 7) // case when octave reaches max number - Seventh octave (6th value)
            {
                octave = (Octaves)0;
            }
            else if ((int)initKey.Octave + octaveMove == -1) // case when octave reaches min number - First octave (0th value)
            {
                octave = (Octaves)6;
            }
            else
            {
                octave = initKey.Octave + octaveMove;
            }
            #endregion

            return new Key(note, accidental, octave);
        }
    }
}

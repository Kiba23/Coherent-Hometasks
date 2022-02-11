using PianoKeyboard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoKeyboard
{
    public class Key
    {
        public Notes Note { get; private set; }
        public Accidentals Accidental { get; private set; }
        public Octaves Octave { get; private set; }


        public Key(Notes note, Accidentals accidental, Octaves octave)
        {
            Note = note;
            Accidental = accidental;
            Octave = octave;

            // Kind of input and correctness checker
            if (KeyHelper.IsKeyHasWrongAccidental(this))
            {
                throw new Exception("Key doesn't have such Accidental.");
            }
        }


        public override bool Equals(object obj)
        {
            var compareKey = obj is Key ? obj as Key : throw new Exception("Wrong object to compare.");

            // Getting the equivalent key of input (caller) object, to check it
            var sameKey = KeyHelper.GetSameKey(this);

            if (this.Note == compareKey.Note && this.Accidental == compareKey.Accidental && this.Octave == compareKey.Octave)
            {
                return true;
            }
            else if (sameKey.Note == compareKey.Note && sameKey.Accidental == compareKey.Accidental && sameKey.Octave == compareKey.Octave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Note}" +
                $"{(Accidental == Accidentals.Sharp ? "#" : "b")} " +
                $"({(int)Octave + 1})";
        }
    }
}

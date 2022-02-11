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
        public Notes Note;
        public Accidentals Accidental;
        public Octaves Octave;


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

            return false;

            //if ()
            //{

            //}
            //else if ()
            //{

            //}
            //else
            //{
            //    return false;
            //}
        }
        public override string ToString()
        {
            return $"{Note}" +
                $"{(Accidental == Accidentals.Sharp ? "#" : "b")} " +
                $"({(int)Octave})";
        }
    }
}

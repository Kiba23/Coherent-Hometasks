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
        private Notes Note;
        private Accidentals Accidental;
        private Octaves Octave;

        public Key(Notes note, Accidentals accidental, Octaves octave)
        {
            Note = note;
            Accidental = accidental;
            Octave = octave;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordnomiconWebApplication
{
    class NoteController
    {
        private NoteController() { }
        public static bool checkNoteName(string note)
        {
            if (note == "A" || note == "A#" || note == "Bb" || note == "B" || note == "B#" || note == "Cb" ||note == "C" || note == "C#" || 
                note == "Db" || note == "D" || note == "D#" || note == "Eb" || note == "E" || note == "E#" || note == "Fb" || note == "F" ||
                note == "F#" || note == "Gb" || note == "G" || note == "G#" || note == "Ab")
            {
                return true;
            }
            else { return false; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordnomiconWebApplication.Musical_Objects
{
    public class ModeController
    {
        public static bool checkModeName (string name)
        {
            if (name == "Lydian" || name == "lydian") { return true; }
            else if (name == "Ionian" || name == "ionian" || name == "Major" || name == "major") { return true; }
            else if (name == "Mixolydian" || name == "mixolydian") { return true; }
            else if (name == "Dorian" || name == "dorian") { return true; }
            else if (name == "Aeolian" || name == "aeolian" || name == "Minor" || name == "minor") { return true; }
            else if (name == "Phrygian" || name == "phrygian") { return true; }
            else if (name == "Locrian" || name == "locrian") { return true; }
            else if (name == "Blues" || name == "blues") { return true; }
            else if (name == "Pentatonic Major" || name == "pentatoninc major") { return true; }
            else if (name == "Pentatonic Minor" || name == "pentatoninc minor") { return true; }
            else if (name == "Suspended" || name == "suspended") { return true; }
            else if (name == "Blues Major" || name == "blues major") { return true; }
            else if (name == "Blues Minor" || name == "blues minor") { return true; }
            else { return false; }
        }
    }
}
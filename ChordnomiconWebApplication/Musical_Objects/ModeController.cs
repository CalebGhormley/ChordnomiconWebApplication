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
            if (name == "Lydian") { return true; }
            else if (name == "Ionian" || name == "Major") { return true; }
            else if (name == "Mixolydian") { return true; }
            else if (name == "Dorian") { return true; }
            else if (name == "Aeolian" || name == "Minor") { return true; }
            else if (name == "Phrygian") { return true; }
            else if (name == "Locrian") { return true; }
            else { return false; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordnomiconWebApplication
{
    class ModeFactory
    {
        public static Mode getModeByName(string name)
        {
            Mode mode = new Mode();
            if (name == "Lydian" || name == "lydian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Lydian");
                mode.setPen(new Pen(Color.Gold, 3));
                mode.setBrush(Brushes.Gold);
            }
            else if (name == "Ionian" || name == "ionian" || name == "Major" || name =="major")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Ionian");
                mode.setPen(new Pen(Color.Gold, 3)); mode.setBrush(Brushes.Gold);
            }
            else if (name == "Mixolydian" || name == "mixolydian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Mixolydian");
                mode.setPen(new Pen(Color.Gold, 3));
                mode.setBrush(Brushes.Gold);
            }
            else if (name == "Dorian" || name == "dorian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Dorian");
                mode.setPen(new Pen(Color.Gold, 3));
                mode.setBrush(Brushes.Gold);
            }
            else if (name == "Aeolian" || name == "aeolian" || name == "Minor" || name == "minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Aeolian");
                mode.setPen(new Pen(Color.Gold, 3));
                mode.setBrush(Brushes.Gold);
            }
            else if (name == "Phrygian" || name == "phrygian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Phrygian");
                mode.setPen(new Pen(Color.Gold, 3));
                mode.setBrush(Brushes.Gold);
            }
            else if (name == "Locrian" || name == "locrian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Locrian");
                mode.setPen(new Pen(Color.Gold, 3)); mode.setBrush(Brushes.Gold);
            }
            else if (name == "Blues" || name == "blues")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Blues");
                mode.setPen(new Pen(Color.MidnightBlue, 3));
                mode.setBrush(Brushes.MidnightBlue);
            }
            else if (name == "Pentatonic Major" || name == "pentatoninc major")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.setName("Pentatoninc Major");
                mode.setPen(new Pen(Color.ForestGreen, 3));
                mode.setBrush(Brushes.ForestGreen);
            }
            else if (name == "Pentatonic Minor" || name == "pentatoninc minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Pentatonic Minor");
                mode.setPen(new Pen(Color.ForestGreen, 3));
                mode.setBrush(Brushes.ForestGreen);
            }
            else if (name == "Suspended" || name == "suspended")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Suspended");
                mode.setPen(new Pen(Color.ForestGreen, 3));
                mode.setBrush(Brushes.ForestGreen);
            }
            else if (name == "Blues Major" || name == "blues major")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.setName("Blues Major");
                mode.setPen(new Pen(Color.ForestGreen, 3));
                mode.setBrush(Brushes.ForestGreen);
            }
            else if (name == "Blues Minor" || name == "blues minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Blues Minor");
                mode.setPen(new Pen(Color.ForestGreen, 3));
                mode.setBrush(Brushes.ForestGreen);
            }
            else { throw new System.ArgumentException("Parameter must have a valid name", "Mode: " + name); }
            return mode;
        }
    }
}

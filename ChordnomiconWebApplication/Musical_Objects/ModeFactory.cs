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
            //--------------------------------------------------------
            //------------------Heptatonic Modes----------------------
            //--------------------------------------------------------

            //------------------Golden Modal Shape---------------------
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
            else if (name == "Ionian" || name == "ionian" || name == "Major" || name == "major")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                if (name == "Ionian" || name == "ionian") { mode.setName("Ionian"); }
                else { mode.setName("Major"); }
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
                if (name == "Aeolian" || name == "aeolian") { mode.setName("Aeolian"); }
                else { mode.setName("Minor"); }
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

            //------------------Silver Modal Shape---------------------
            else if (name == "Lydian Augmented" || name == "lydian augmented" || name == "Lydian augmented")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Lydian Augmented");
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }
            else if (name == "Lydian Flat-Seven" || name == "lydian flat-seven" || name == "Lydian flat-seven" ||
                name == "Lydian Flat Seven" || name == "lydian flat seven" || name == "Lydian flat seven" ||
                name == "Lydian flat 7" || name == "Lydian b7" || name == "Acoustic" || name == "acoustic")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                if (name == "Acoustic" || name == "acoustic") { mode.setName("Acoustic"); }
                else { mode.setName("Lydian Flat-Seven"); }
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }
            else if (name == "Half Diminished" || name == "Half diminished" || name == "half diminished")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Half Diminished");
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }
            else if (name == "Harmonic Mixolydian" || name == "Harmonic mixolydian" || name == "harmonic mixolydian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Harmonic Mixolydian");
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }
            else if (name == "Altered" || name == "altered")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Altered");
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }
            else if (name == "Melodic Minor" || name == "Melodic minor" || name == "melodic minor" ||
                name == "Jazz Melodic Minor" || name == "Jazz melodic minor" || name == "jazz melodic minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                if (name == "Melodic Minor" || name == "Melodic minor" || name == "melodic minor") { mode.setName("Melodic Minor"); }
                else { mode.setName("Jazz Melodic Minor"); }
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }
            else if (name == "Harmonic Phrygian" || name == "Harmonic phrygian" || name == "harmonic phrygian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Harmonic Phrygian");
                mode.setPen(new Pen(Color.LightSlateGray, 3)); mode.setBrush(Brushes.LightSlateGray);
            }

            //------------------Bronze Modal Shape---------------------
            else if (name == "Super Augmented" || name == "Super augmented" || name == "super augmented")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Super Augmented*");
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }
            else if (name == "Mixolydian Augmented" || name == "Mixolydian augmented" || name == "mixolydian augmented")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Mixolydian Augmented");
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }
            else if (name == "Minor Lydian" || name == "Minor lydian" || name == "minor lydian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Minor Lydian");
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }
            else if (name == "Major Locrian" || name == "Major locrian" || name == "major locrian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Major Locrian");
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }
            else if (name == "Aeolian Diminished" || name == "Aeolian diminished" || name == "aeolian diminished")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Aeolian Diminished");
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }
            else if (name == "Super Diminished" || name == "Super diminished" || name == "super diminished")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Super Diminished*");
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }
            else if (name == "Neapolitan Major" || name == "Neapolitan major" || name == "neapolitan major" ||
                name == "Neapolitan" || name == "neapolitan")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                if (name == "Neapolitan" || name == "neapolitan") { mode.setName("Neapolitan"); }
                else { mode.setName("Neapolitan Major"); }
                mode.setPen(new Pen(Color.DarkOrange, 3)); mode.setBrush(Brushes.DarkOrange);
            }

            //------------------Other Heptatonic Modal Shapes---------------------
            else if (name == "Hungarian Minor" || name == "Hungarian minor" || name == "hungarian minor" ||
                name == "Gypsy" || name == "gypsy")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                if (name == "Gypsy" || name == "gypsy") { mode.setName("Gypsy"); }
                else { mode.setName("Hungarian Minor"); }
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            /*
            else if (name == "Diminished Dorian" || name == "Diminished dorian" || name == "diminished dorian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Diminished Dorian*");
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            else if (name == "Dominant Augmented" || name == "Dominant augmented" || name == "dominant augmented")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Dominant Augmented*");
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            else if (name == "Melodic Locrian" || name == "Melodic locrian" || name == "melodic locrian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Melodic Locrian*");
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            */
            else if (name == "Double Harmonic" || name == "Double harmonic" || name == "double harmonic" ||
                name == "Flamenco" || name == "flamenco")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                if (name == "Flamenco" || name == "flamenco") { mode.setName("Flamenco"); }
                else { mode.setName("Double Harmonic"); }
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            /*
            else if (name == "Augmented Mixolydian" || name == "Augmented mixolydian" || name == "augmented mixolydian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Augmented Mixolydian*");
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            else if (name == "Harmonic Locrian" || name == "Harmonic locrian" || name == "harmonic locrian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim7"));
                mode.setName("Harmonic Locrian*");
                mode.setPen(new Pen(Color.Magenta, 3)); mode.setBrush(Brushes.Magenta);
            }
            */
            else if (name == "Harmonic Minor" || name == "Harmonic minor" || name == "harmonic minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Harmonic Minor");
                mode.setPen(new Pen(Color.Fuchsia, 3)); mode.setBrush(Brushes.Fuchsia);
            }
            else if (name == "Ukrainian Dorian" || name == "Ukrainian dorian" || name == "ukrainian dorian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Ukrainian Dorian");
                mode.setPen(new Pen(Color.Fuchsia, 3)); mode.setBrush(Brushes.Fuchsia);
            }
            else if (name == "Phrygian Dominant" || name == "Phrygian dominant" || name == "phrygian dominant")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Phrygian Dominant");
                mode.setPen(new Pen(Color.Fuchsia, 3)); mode.setBrush(Brushes.Fuchsia);
            }
            else if (name == "Harmonic Major" || name == "Harmonic major" || name == "harmonic major")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Harmonic Major");
                mode.setPen(new Pen(Color.Maroon, 3)); mode.setBrush(Brushes.Maroon);
            }
            else if (name == "Pfluke" || name == "pfluke")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Pfluke");
                mode.setPen(new Pen(Color.Maroon, 3)); mode.setBrush(Brushes.Maroon);
            }
            else if (name == "Neapolitan Minor" || name == "Neapolitan minor" || name == "neapolitan minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Neapolitan Minor");
                mode.setPen(new Pen(Color.DeepPink, 3)); mode.setBrush(Brushes.DeepPink);
            }
            else if (name == "Enigmatic" || name == "enigmatic")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Enigmatic");
                mode.setPen(new Pen(Color.IndianRed, 3)); mode.setBrush(Brushes.IndianRed);
            }
            else if (name == "Persian" || name == "persian")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Persian");
                mode.setPen(new Pen(Color.LightCoral, 3)); mode.setBrush(Brushes.LightCoral);
            }
            else if (name == "Blues With Flat-Four" || name == "Blues with Flat-Four" || name == "Blues with Flat-four"
                || name == "Blues with flat-four" || name == "Blues with flat-four")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Blues with Flat-Four");
                mode.setPen(new Pen(Color.PaleVioletRed, 3)); mode.setBrush(Brushes.PaleVioletRed);
            }
            //--------------------------------------------------------
            //------------------Pentatonic Modes----------------------
            //--------------------------------------------------------

            //------------------Phi Modal Shape----=------------------
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
            //------------------Other Pentatonic Modes----------------------
            else if (name == "Hirajoshi" || name == "hirajoshi")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Hirajoshi");
                mode.setPen(new Pen(Color.LimeGreen, 3));
                mode.setBrush(Brushes.LimeGreen);
            }
            else if (name == "In" || name == "in")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.setName("In");
                mode.setPen(new Pen(Color.LimeGreen, 3));
                mode.setBrush(Brushes.LimeGreen);
            }
            else if (name == "Iwato" || name == "iwato")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Iwato");
                mode.setPen(new Pen(Color.LimeGreen, 3));
                mode.setBrush(Brushes.LimeGreen);
            }
            else if (name == "Insen" || name == "insen")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Insen");
                mode.setPen(new Pen(Color.LimeGreen, 3));
                mode.setBrush(Brushes.LimeGreen);
            }

            //--------------------------------------------------------
            //------------------Hexatonic Modes-----------------------
            //--------------------------------------------------------
            
            //-------------------Blues Modal Shape-------------------
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
            /*
            else if (name == "Harmonic Blues" || name == "Harmonic blues" || name == "harmonic blues")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.setName("Harmonic Blues");
                mode.setPen(new Pen(Color.MidnightBlue, 3));
                mode.setBrush(Brushes.MidnightBlue);
            }
            else if (name == "Dominant Blues Minor" || name == "Dominant Blues minor" || name == "Dominant blues minor" || name == "dominant blues minor")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Dominant Blues Minor");
                mode.setPen(new Pen(Color.MidnightBlue, 3));
                mode.setBrush(Brushes.MidnightBlue);
            }
            else if (name == "Nores Blues" || name == "Nores blues" || name == "nores blues")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Nores Blues");
                mode.setPen(new Pen(Color.MidnightBlue, 3));
                mode.setBrush(Brushes.MidnightBlue);
            }
            else if (name == "Dominant Blues Major" || name == "Dominant Blues major" || name == "Dominant blues major" || name == "dominant blues major")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Dominant Blues Major");
                mode.setPen(new Pen(Color.MidnightBlue, 3));
                mode.setBrush(Brushes.MidnightBlue);
            }
            else if (name == "Melodic Blues" || name == "Melodic blues" || name == "melodic blues")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Melodic Blues");
                mode.setPen(new Pen(Color.MidnightBlue, 3));
                mode.setBrush(Brushes.MidnightBlue);
            }
            */
            //--------------Symmetric Hexatonic Modal Shapes----------
            else if (name == "Whole Tone" || name == "Whole tone" || name == "whole tone" ||
                name == "Whole Step" || name == "Whole step" || name == "whole step")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                if (name == "Whole Step" || name == "Whole step" || name == "whole step") { mode.setName("Whole Step"); }
                else { mode.setName("Whole Tone"); }
                mode.setPen(new Pen(Color.CadetBlue, 3));
                mode.setBrush(Brushes.CadetBlue);
            }
            else if (name == "Augmented" || name == "augmented" ||
                name == "Hexatonic Augmented" || name == "Hexatonic augmented" || name == "hexatonic augmented")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                if (name == "Augmented" || name == "augmented") { mode.setName("Augmented"); }
                else { mode.setName("Hexatonic Augmented"); }
                mode.setPen(new Pen(Color.CornflowerBlue, 3));
                mode.setBrush(Brushes.CornflowerBlue);
            }
            else if (name == "Hexatonic Diminished" || name == "Hexatonic diminished" || name == "hexatonic diminished")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim7"));
                mode.setName("Hexatonic Diminished");
                mode.setPen(new Pen(Color.CornflowerBlue, 3));
                mode.setBrush(Brushes.CornflowerBlue);
            }

            //--------------Other Hexatonic Modal Shapes----------
            else if (name == "Tritone" || name == "tritone")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Tritone");
                mode.setPen(new Pen(Color.BlueViolet, 3));
                mode.setBrush(Brushes.BlueViolet);
            }
            else if (name == "Prometheus" || name == "prometheus")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Prometheus");
                mode.setPen(new Pen(Color.DodgerBlue, 3));
                mode.setBrush(Brushes.DodgerBlue);
            }
            else if (name == "Istran" || name == "istran")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim6"));
                mode.setName("Istran");
                mode.setPen(new Pen(Color.LightSteelBlue, 3));
                mode.setBrush(Brushes.LightSteelBlue);
            }
            //--------------------------------------------------------
            //------------------Octatonic Modes----------------------
            //--------------------------------------------------------

            //--------------Symmetric Octatonic Modal Shape------------
            else if (name == "Diminished Whole-Half" || name == "Diminished Whole-half" || name == "Diminished whole-half" || name == "diminished whole-half" ||
                name == "Diminished Whole Half" || name == "Diminished Whole half" || name == "Diminished whole half" || name == "diminished whole half")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("aug5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Diminished Whole-Half");
                mode.setPen(new Pen(Color.Purple, 3));
                mode.setBrush(Brushes.Purple);
            }
            else if (name == "Diminished Half-Whole" || name == "Diminished Half-whole" || name == "Diminished half-whole" || name == "diminished half-whole" ||
                name == "Diminished Half Whole" || name == "Diminished Half whole" || name == "Diminished half whole" || name == "diminished half whole")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.setName("Diminished Half-Whole");
                mode.setPen(new Pen(Color.Purple, 3));
                mode.setBrush(Brushes.Purple);
            }

            //--------------Other Octatonic Modal Shapes------------
            else if (name == "Major Bebop" || name == "Major bebop" || name == "major bebop")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Major Bebop");
                mode.setPen(new Pen(Color.MediumPurple, 3));
                mode.setBrush(Brushes.MediumPurple);
            }
            else if (name == "Bebop Dominant" || name == "Bebop dominant" || name == "bebop dominant")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Bebop Dominant");
                mode.setPen(new Pen(Color.MediumPurple, 3));
                mode.setBrush(Brushes.MediumPurple);
            }
            else if (name == "Chromatic" || name == "chromatic")
            {
                mode.addInterval(IntervalFactory.getIntervalByName("R"));
                mode.addInterval(IntervalFactory.getIntervalByName("m2"));
                mode.addInterval(IntervalFactory.getIntervalByName("M2"));
                mode.addInterval(IntervalFactory.getIntervalByName("m3"));
                mode.addInterval(IntervalFactory.getIntervalByName("M3"));
                mode.addInterval(IntervalFactory.getIntervalByName("P4"));
                mode.addInterval(IntervalFactory.getIntervalByName("dim5"));
                mode.addInterval(IntervalFactory.getIntervalByName("P5"));
                mode.addInterval(IntervalFactory.getIntervalByName("m6"));
                mode.addInterval(IntervalFactory.getIntervalByName("M6"));
                mode.addInterval(IntervalFactory.getIntervalByName("m7"));
                mode.addInterval(IntervalFactory.getIntervalByName("M7"));
                mode.setName("Chromatic");
                mode.setPen(new Pen(Color.DarkRed, 3));
                mode.setBrush(Brushes.DarkRed);
            }
            else { throw new System.ArgumentException("Parameter must have a valid name", "Mode: " + name); }
            return mode;
        }
    }
}

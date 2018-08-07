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
            else if (name == "Lydian Augmented" || name == "lydian augmented" || name == "Lydian augmented") { return true; }
            else if (name == "Lydian Flat-Seven" || name == "lydian flat-seven" || name == "Lydian flat-seven" ||
                name == "Lydian Flat Seven" || name == "lydian flat seven" || name == "Lydian flat seven" ||
                name == "Lydian flat 7" || name == "Lydian b7" || name == "Acoustic" || name == "acoustic") { return true; }
            else if (name == "Half Diminished" || name == "Half diminished" || name == "half diminished") { return true; }
            else if (name == "Harmonic Mixolydian" || name == "Harmonic mixolydian" || name == "harmonic mixolydian") { return true; }
            else if (name == "Altered" || name == "altered") { return true; }
            else if (name == "Melodic Minor" || name == "Melodic minor" || name == "melodic minor" ||
                name == "Jazz Melodic Minor" || name == "Jazz melodic minor" || name == "jazz melodic minor") { return true; }
            else if (name == "Harmonic Phrygian" || name == "Harmonic phrygian" || name == "harmonic phrygian") { return true; }
            else if (name == "Super Augmented" || name == "Super augmented" || name == "super augmented") { return true; }
            else if (name == "Mixolydian Augmented" || name == "Mixolydian augmented" || name == "mixolydian augmented") { return true; }
            else if (name == "Minor Lydian" || name == "Minor lydian" || name == "minor lydian") { return true; }
            else if (name == "Major Locrian" || name == "Major locrian" || name == "major locrian") { return true; }
            else if (name == "Aeolian Diminished" || name == "Aeolian diminished" || name == "aeolian diminished") { return true; }
            else if (name == "Super Diminished" || name == "Super diminished" || name == "super diminished") { return true; }
            else if (name == "Neapolitan Major" || name == "Neapolitan major" || name == "neapolitan major" ||
                name == "Neapolitan" || name == "neapolitan") { return true; }
            else if (name == "Hungarian Minor" || name == "Hungarian minor" || name == "hungarian minor" ||
                name == "Gypsy" || name == "gypsy") { return true; }
            else if (name == "Double Harmonic" || name == "Double harmonic" || name == "double harmonic" ||
                name == "Flamenco" || name == "flamenco") { return true; }
            else if (name == "Harmonic Minor" || name == "Harmonic minor" || name == "harmonic minor") { return true; }
            else if (name == "Ukrainian Dorian" || name == "Ukrainian dorian" || name == "ukrainian dorian") { return true; }
            else if (name == "Phrygian Dominant" || name == "Phrygian dominant" || name == "phrygian dominant") { return true; }
            else if (name == "Harmonic Major" || name == "Harmonic major" || name == "harmonic major") { return true; }
            else if (name == "Pfluke" || name == "pfluke") { return true; }
            else if (name == "Neapolitan Minor" || name == "Neapolitan minor" || name == "neapolitan minor") { return true; }
            else if (name == "Enigmatic" || name == "enigmatic") { return true; }
            else if (name == "Persian" || name == "persian") { return true; }
            else if (name == "Blues With Flat-Four" || name == "Blues with Flat-Four" || name == "Blues with Flat-four"
                || name == "Blues with flat-four" || name == "Blues with flat-four") { return true; }
            else if (name == "Hirajoshir" || name == "hirajoshi") { return true; }
            else if (name == "In" || name == "in") { return true; }
            else if (name == "Iwato" || name == "iwato") { return true; }
            else if (name == "Insen" || name == "insen") { return true; }
            else if (name == "Whole Tone" || name == "Whole tone" || name == "whole tone") { return true; }
            else if (name == "Augmented" || name == "augmented" ||
                name == "Hexatonic Augmented" || name == "Hexatonic augmented" || name == "hexatonic augmented") { return true; }
            else if (name == "Hexatonic Diminished" || name == "Hexatonic diminished" || name == "hexatonic diminished") { return true; }
            else if (name == "Tritone" || name == "tritone") { return true; }
            else if (name == "Prometheus" || name == "prometheus") { return true; }
            else if (name == "Istran" || name == "istran") { return true; }
            else if (name == "Diminished Whole-Half" || name == "Diminished Whole-half" || name == "Diminished whole-half" || name == "diminished whole-half" ||
                name == "Diminished Whole Half" || name == "Diminished Whole half" || name == "Diminished whole half" || name == "diminished whole half") { return true; }
            else if (name == "Diminished Half-Whole" || name == "Diminished Half-whole" || name == "Diminished half-whole" || name == "diminished half-whole" ||
                name == "Diminished Half Whole" || name == "Diminished Half whole" || name == "Diminished half whole" || name == "diminished half whole") { return true; }
            else if (name == "Major Bebop" || name == "Major bebop" || name == "major bebop") { return true; }
            else if (name == "Bebop Dominant" || name == "Bebop dominant" || name == "bebop dominant") { return true; }
            else if (name == "Chromatic" || name == "chromatic") { return true; }   
            else { return false; }
        }
    }
}
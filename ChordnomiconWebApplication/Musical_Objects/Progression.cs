using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ChordnomiconWebApplication
{
    static class Progression
    {
        private static Note _key = NoteFactory.getNoteByName("D");
        public static void changeKey(Note key) { _key = key; }
        public static Note getKey() { return _key; }

        private static Mode _mode = ModeFactory.getModeByName("Dorian");
        public static void setMode (Mode mode) { _mode = mode; }
        public static void changeMode(string mode) { _mode = ModeFactory.getModeByName(mode); }
        public static Mode getMode() { return _mode; }

        private static Guitar _guitar = new Guitar();
        public static Guitar getGuitar() { return _guitar; }
        
        private static List<Chord> chords = new List<Chord>();
        private static List<TabChord> tablature = new List<TabChord>();

        public static List<Point[]> ChordPolygons = new List<Point[]>();

        private static List<Note> RecommendedDegrees = new List<Note>();
        private static List<Chord> RecommendedChords = new List<Chord>();
 
        public static void changeTuning(Note six, Note five, Note four, Note three, Note two, Note one) 
        {
            _guitar.changeTunning(six, five, four, three, two, one);
            TabChord tempTab;
            for (int i = 0; i < getSize(); i++)
            {
                tempTab = TabChordFactory.getTabByChord(chords.ElementAt(i), tablature.ElementAt(i).getPitch(), _guitar);
                tablature.RemoveAt(i);
                tablature.Insert(i, tempTab);
            }
        }
        public static string getTuning()
        {
            string tuning = "";
            for (int i = 6; i > 0; i--)
            {
                tuning = tuning + _guitar.getNote(i, 0, _key).getName();
                if(i > 1) { tuning = tuning + ", "; }
            }
            return tuning;
        }

        public static void addChord(Chord chord)
        {
            chords.Add(chord);
            tablature.Add(TabChordFactory.getTabByChord(chord, 1, _guitar));
        }
        public static void replaceChord(int location, Chord chord)
        {
            chords.RemoveAt(location);
            chords.Insert(location, chord);
            tablature.Insert(location, TabChordFactory.getTabByChord(chord, 1, _guitar));
        }
        public static void swapChords(int locationOne, int locationTwo)
        {
            if (locationOne < 0 || locationOne >= getSize())
            { throw new System.ArgumentException("Parameter must have a valid name", "value: " + locationOne); }
            else if(locationTwo < 0 || locationTwo >= getSize())
            { throw new System.ArgumentException("Parameter must have a valid name", "value: " + locationTwo); }

            Chord tempOne = chords.ElementAt(locationOne);
            Chord tempTwo = chords.ElementAt(locationTwo);
            chords.RemoveAt(locationOne);
            chords.Insert(locationOne, tempTwo);
            chords.RemoveAt(locationTwo);
            chords.Insert(locationTwo, tempOne);

            TabChord tempTabOne = tablature.ElementAt(locationOne);
            TabChord tempTabTwo = tablature.ElementAt(locationTwo);
            tablature.RemoveAt(locationOne);
            tablature.Insert(locationOne, tempTabTwo);
            tablature.RemoveAt(locationTwo);
            tablature.Insert(locationTwo, tempTabOne);

            Point[] tempPolygonOne = ChordPolygons.ElementAt(locationOne);
            Point[] tempPolygonTwo = ChordPolygons.ElementAt(locationTwo);
            changeChordPolygon(locationOne, tempPolygonTwo);
            changeChordPolygon(locationTwo, tempPolygonOne);
        }
        public static void removeChord(int location)
        {
            chords.RemoveAt(location);
            tablature.RemoveAt(location);
        }
        public static void clearProgression()
        {
            chords.Clear();
            tablature.Clear();
            ChordPolygons.Clear();
        }
        public static string getChordNames ()
        {
            string names = "";
            Chord _chord;
            for (int i = 0; i < chords.Count; i++ )
            {
                _chord = chords.ElementAt(i);
                names = names + _chord.getName();
                if (i < chords.Count - 1) { names = names + ", "; }
            }
            return names;
        }
        public static Chord getChord(int position)
        {
            return(chords.ElementAt(position));
        }
        public static int getSize() { return chords.Count; }

        public static string getTabNumber(int _chord, int _string)
        { return tablature.ElementAt(_chord).getFretNumber(_string); }

        public static int getTabPitch(int _chord)
        { return tablature.ElementAt(_chord).getPitch(); }

        public static void changeTabPitch (int chordPosition, int newPitchPosition)
        {
            Chord tempChord = chords.ElementAt(chordPosition);
            tablature.RemoveAt(chordPosition);
            tablature.Insert(chordPosition, TabChordFactory.getTabByChord(tempChord, newPitchPosition, _guitar));
        }

        public static void SetRecommededDegrees (List<Note> degrees) { RecommendedDegrees = degrees; }
        public static List<Note> GetRecommendedDegrees() { return RecommendedDegrees; }

        public static void SetRecommendedChords (List<Chord> chords) { RecommendedChords = chords; }
        public static List<Chord> GetRecommendedChords() { return RecommendedChords; }

        public static void addChordPolygon(Point[] polygon) { ChordPolygons.Add(polygon); }
        public static void changeChordPolygon(int position, Point[] polygon)
        {
            ChordPolygons.RemoveAt(position);
            ChordPolygons.Insert(position, polygon);
        }
        public static Point[] getChordPolygon(int position) { return ChordPolygons.ElementAt(position); }
        public static void removeChordPolygon (int position) { ChordPolygons.RemoveAt(position); }
        public static void clearChordPolygons() { ChordPolygons.Clear(); }
    }
}

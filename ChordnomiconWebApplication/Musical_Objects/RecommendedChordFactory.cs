using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordnomiconWebApplication.Musical_Objects
{
    class RecommendedChordFactory
    {
        public static List<Note> GetFirstRecommendedDegrees (Note key, Mode mode)
        {
            List<Note> notes = new List<Note>();
            int noteOffset;

            notes.Add(key);

            if (mode.containsInterval(7))
            {
                noteOffset = key.getValue() + 7;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(5))
            {
                noteOffset = key.getValue() + 5;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(8))
            {
                noteOffset = key.getValue() + 8;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(9))
            {
                noteOffset = key.getValue() + 9;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(3))
            {
                noteOffset = key.getValue() + 3;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(4))
            {
                noteOffset = key.getValue() + 4;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(1))
            {
                noteOffset = key.getValue() + 1;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(2))
            {
                noteOffset = key.getValue() + 2;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(10))
            {
                noteOffset = key.getValue() + 10;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(11))
            {
                noteOffset = key.getValue() + 11;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(6))
            {
                noteOffset = key.getValue() + 6;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            return notes;
        }

        public static List<Note> GetRecommendedDegreesByLast(Note key, Note lastTonic, Mode mode)
        {
            List<Note> notes = new List<Note>();
            int noteOffset;
            int distance = lastTonic.getValue() - key.getValue();
            if (distance < 12) { distance = distance + 12; }

            notes.Add(lastTonic);

            if (mode.containsInterval(5 + distance) || mode.containsInterval(5 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 5;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(2 + distance) || mode.containsInterval(2 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 2;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(1 + distance) || mode.containsInterval(1 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 1;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(4 + distance) || mode.containsInterval(4 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 4;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(3 + distance) || mode.containsInterval(3 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 3;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(7 + distance) || mode.containsInterval(7 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 7;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(10 + distance) || mode.containsInterval(10 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 10;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(11 + distance) || mode.containsInterval(11 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 11;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(8 + distance) || mode.containsInterval(8 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 8;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(9 + distance) || mode.containsInterval(9 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 9;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            if (mode.containsInterval(6 + distance) || mode.containsInterval(6 + distance - 12))
            {
                noteOffset = lastTonic.getValue() + 6;
                if (noteOffset > 12) { noteOffset = noteOffset - 12; }
                notes.Add(NoteFactory.getNoteByValue(noteOffset, key));
            }
            return notes;
        }
        public static List<Chord> GetChordsByDegree (Note key, Note tonic, Mode mode)
        {
            int i = tonic.getValue() - key.getValue();
            if (i < 0) { i = i + 12; }
            List<Chord> chords = new List<Chord>();

            // Triads and five diad
            // "X" major 0 4 7 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName())); }

            // "Xm" minor 0 3 7
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m")); }

            // "Xdim" diminished 0 3 6
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "dim")); }

            // "Xaug" augmented 0 4 8
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(8 + i) || (mode.containsInterval((8 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "aug")); }

            // "X(b5)" flat five 0 4 6
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "(b5)")); }

            // "X5" five diad 0 7
            if ((mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "5")); }

            // "Xsus" suspended 0 5 7
            if ((mode.containsInterval(5 + i) || (mode.containsInterval((5 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "sus")); }

            // "Xsus2" suspended two 0 2 7
            if ((mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "sus2")); }

            // Sevens
            // "X7" seven 0 4 7 10
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7")); }

            // "Xm7" minor seven 0 3 7 10
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m7")); }

            // "X7sus" suspended seven 0 5 7 10
            if ((mode.containsInterval(5 + i) || (mode.containsInterval((5 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7sus")); }

            // "X7(b5)" suspended seven 0 4 6 10
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7(b5)")); }

            // "Xm7(b5)" suspended seven 0 3 6 10
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m7(b5)")); }

            // "Xmaj7" major seven 0 4 7 11
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(11 + i) || (mode.containsInterval((11 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "maj7")); }

            // "Xm(maj7)" minor with major seven 0 3 7 11
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(11 + i) || (mode.containsInterval((11 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m(maj7)")); }

            // "Xmaj7(b5)" major seven flat five 0 4 6 11
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12)))
            && (mode.containsInterval(11 + i) || (mode.containsInterval((11 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "maj7(b5)")); }

            // "X7+" augmented seven 0 4 8 10
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(8 + i) || (mode.containsInterval((8 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7+")); }

            // "X7+(b9)" augmented seven 0 4 8 10 1
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(8 + i) || (mode.containsInterval((8 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(1 + i) || (mode.containsInterval((1 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7+(b9)")); }

            // Sixes
            // "X6" seven 0 4 7 9 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "6")); }

            // "X6/9" seven 0 4 7 9 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "6/9")); }

            // "Xm6" seven 0 3 7 9
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m6")); }

            // "Xm6/9" seven 0 3 7 9 2
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m6/9")); }

            // Nines
            // "X(add9)" add nine 0 4 7 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "(add9)")); }

            // "X9" nine 0 4 7 10 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "9")); }

            // "Xmaj9" major nine 0 4 7 11 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(11 + i) || (mode.containsInterval((11 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "maj9")); }

            // "Xm9(maj7)" minor nine with major seven 0 3 7 11 2
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(11 + i) || (mode.containsInterval((11 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m9(maj7)")); }

            // "X7(b9)" seven flat nine 0 4 7 10 1
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((1 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7(b9)")); }

            // "X7(#9)" major seven flat five 0 4 7 10 3
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "7(#9)")); }

            // "X9(#11)" nine with sharp eleven 0 4 7 10 2 6
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "9(#11)")); }

            // "X9+" augmented nine 0 4 8 10 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(8 + i) || (mode.containsInterval((8 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "9+")); }

            // "X9(b5)" nine flat five 0 4 6 10 2
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "9(b5)")); }

            // Elevens
            // "X11" eleven 0 4 7 10 2 5 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12)))
            && (mode.containsInterval(5 + i) || (mode.containsInterval((5 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "11")); }

            // "Xm11" minor eleven 0 3 7 10 2 5 
            if ((mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12)))
            && (mode.containsInterval(5 + i) || (mode.containsInterval((5 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "m11")); }

            // "XM11" major eleven 0 4 7 10 2 5 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(11 + i) || (mode.containsInterval((11 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12)))
            && (mode.containsInterval(5 + i) || (mode.containsInterval((5 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "M11")); }

            // Thirteens
            // "X13" thirteen 0 4 7 10 2 9 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(2 + i) || (mode.containsInterval((2 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "13")); }

            // "X13(b9)" thirteen flat nine 0 4 7 10 1 9 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(1 + i) || (mode.containsInterval((1 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "13(b9)")); }

            // "X13(#9)" thirteen sharp nine 0 4 7 10 3 9 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(7 + i) || (mode.containsInterval((7 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(3 + i) || (mode.containsInterval((3 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "13(#9)")); }

            // "X13(b9b5)" thirteen 0 4 6 10 1 9 
            if ((mode.containsInterval(4 + i) || (mode.containsInterval((4 + i) - 12)))
            && (mode.containsInterval(6 + i) || (mode.containsInterval((6 + i) - 12)))
            && (mode.containsInterval(10 + i) || (mode.containsInterval((10 + i) - 12)))
            && (mode.containsInterval(1 + i) || (mode.containsInterval((1 + i) - 12)))
            && (mode.containsInterval(9 + i) || (mode.containsInterval((9 + i) - 12))))
            { chords.Add(ChordFactory.getChordByName(tonic.getName() + "13(b9b5)")); }

            return chords;
        }


        private static Note calculateNote(int distance, Note _key)
        {
            int next = _key.getValue() + distance;
            if (next > 12) { next = next - 12; }
            return (NoteFactory.getNoteByValue(next, _key));
        }
    }
}
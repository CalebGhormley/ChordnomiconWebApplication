using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordnomiconWebApplication
{
    class TabChordFactory
    {
        private TabChordFactory() { }
        public static TabChord getTabByChord(Chord chord, int pitchPosition, Guitar guitar)
        {
            int index = 0;
            int bassString = 0;
            string buildDirection = "";
            int currentPitchPosition = 0;
            bool foundNoteThree = true;
            bool foundNoteFour = true;
            bool foundNoteFive = true;
            bool foundNoteSix = true;

            bool foundNoteTwo = false;
            if (chord.getSize() > 2)
            {
                foundNoteThree = false;
                if(chord.getSize() > 3)
                {
                    foundNoteFour = false;
                    if(chord.getSize() > 4)
                    {
                        foundNoteFive = false;
                        if(chord.getSize() > 5)
                        {
                            foundNoteSix = false;
                        }
                    }
                }
            }
            TabChord tabChord = new TabChord();
            tabChord.setPitch(pitchPosition);
            while (currentPitchPosition < pitchPosition)
            {
                if(guitar.getNote(6, index, chord.getNoteAt(0)).getValue() == chord.getNoteAt(0).getValue())
                {
                    bassString = 6;
                    tabChord.setFretNumber(6, index.ToString());
                    currentPitchPosition = currentPitchPosition + 1;
                    buildDirection = "right";
                    if (index >=3)
                    {
                        buildDirection = "left";
                        if(currentPitchPosition < pitchPosition)
                        {
                            currentPitchPosition = currentPitchPosition + 1;
                            buildDirection = "right";
                        }
                    }
                    if (currentPitchPosition < pitchPosition) { index = index + 1; }
                }
                else if (guitar.getNote(5, index, chord.getNoteAt(0)).getValue() == chord.getNoteAt(0).getValue())
                {
                    bassString = 5;
                    tabChord.setFretNumber(6, "X");
                    tabChord.setFretNumber(5, index.ToString());
                    currentPitchPosition = currentPitchPosition + 1;
                    buildDirection = "right";
                    if (index >= 3)
                    {
                        buildDirection = "left";
                        if (currentPitchPosition < pitchPosition)
                        {
                            currentPitchPosition = currentPitchPosition + 1;
                            buildDirection = "right";
                        }
                    }
                    if (currentPitchPosition < pitchPosition) { index = index + 1; }
                }
                else if (guitar.getNote(4, index, chord.getNoteAt(0)).getValue() == chord.getNoteAt(0).getValue())
                {
                    bassString = 4;
                    tabChord.setFretNumber(6, "X");
                    tabChord.setFretNumber(5, "X");
                    tabChord.setFretNumber(4, index.ToString());
                    currentPitchPosition = currentPitchPosition + 1;
                    buildDirection = "right";
                    if (index >= 3)
                    {
                        buildDirection = "left";
                        if (currentPitchPosition < pitchPosition)
                        {
                            currentPitchPosition = currentPitchPosition + 1;
                            buildDirection = "right";
                        }
                    }
                    if (currentPitchPosition < pitchPosition) { index = index + 1; }
                }
                else { index = index + 1; }
            }

            int tempValue = 0;
            int nextString = bassString - 1;
            bool found;
            if(buildDirection == "right")
            {
                while (nextString > 0)
                {
                    found = false;
                    for (int i = index + 3; i >= index; i--)
                    {
                        for(int j = 0; j < chord.getSize(); j++)
                        {
                            if (chord.getNoteAt(j).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                found = true;
                                tempValue = chord.getNoteAt(j).getValue();
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                    }
                    if (tempValue == chord.getNoteAt(1).getValue()) { foundNoteTwo = true; }
                    else if (chord.getSize() >= 3 && tempValue == chord.getNoteAt(2).getValue()) { foundNoteThree = true; }
                    else if (chord.getSize() >= 4 && tempValue == chord.getNoteAt(3).getValue()) { foundNoteFour = true; }
                    else if (chord.getSize() >= 5 && tempValue == chord.getNoteAt(4).getValue()) { foundNoteFive = true; }
                    else if (chord.getSize() == 6 && tempValue == chord.getNoteAt(5).getValue()) { foundNoteSix = true; }
                    if (found == false) { tabChord.setFretNumber(nextString, "X"); }
                    nextString = nextString - 1;
                }
                if (!foundNoteTwo)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteTwo)
                    {
                        for (int i = index + 3; i >= index; i--)
                        {
                            if (chord.getNoteAt(1).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteTwo = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteThree)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteThree)
                    {
                        for (int i = index + 3; i >= index; i--)
                        {
                            if (chord.getNoteAt(2).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteThree = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteFour)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteFour)
                    {
                        for (int i = index + 3; i >= index; i--)
                        {
                            if (chord.getNoteAt(3).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteFour = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteFive)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteFive)
                    {
                        for (int i = index + 3; i >= index; i--)
                        {
                            if (chord.getNoteAt(4).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteFive = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteSix)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteSix)
                    {
                        for (int i = index + 3; i >= index; i--)
                        {
                            if (chord.getNoteAt(5).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteSix = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
            }
            else if (buildDirection == "left")
            {
                while (nextString > 0)
                {
                    found = false;
                    for (int i = index; i >= index - 3; i--)
                    {
                        for (int j = 0; j < chord.getSize(); j++)
                        {
                            if (chord.getNoteAt(j).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                found = true;
                                tempValue = chord.getNoteAt(j).getValue();
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                    }

                    if (tempValue == chord.getNoteAt(1).getValue()) { foundNoteTwo = true; }
                    else if (chord.getSize() >= 3 && tempValue == chord.getNoteAt(2).getValue()) { foundNoteThree = true; }
                    else if (chord.getSize() >= 4 && tempValue == chord.getNoteAt(3).getValue()) { foundNoteFour = true; }
                    else if (chord.getSize() >= 5 && tempValue == chord.getNoteAt(4).getValue()) { foundNoteFive = true; }
                    else if (chord.getSize() == 6 && tempValue == chord.getNoteAt(5).getValue()) { foundNoteSix = true; }
                    if (found == false) { tabChord.setFretNumber(nextString, "X"); }
                    nextString = nextString - 1;
                }
                if (!foundNoteTwo)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteTwo)
                    {
                        for (int i = index; i >= index - 3; i--)
                        {
                            if (chord.getNoteAt(1).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteTwo = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteThree)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteThree)
                    {
                        for (int i = index; i >= index - 3; i--)
                        {
                            if (chord.getNoteAt(2).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteThree = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteFour)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteFour)
                    {
                        for (int i = index; i >= index - 3; i--)
                        {
                            if (chord.getNoteAt(3).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteFour = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteFive)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteFive)
                    {
                        for (int i = index; i >= index - 3; i--)
                        {
                            if (chord.getNoteAt(4).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteFive = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
                if (!foundNoteSix)
                {
                    nextString = bassString - 1;
                    while (nextString > 0 && !foundNoteSix)
                    {
                        for (int i = index; i >= index - 3; i--)
                        {
                            if (chord.getNoteAt(5).getValue() == guitar.getNote(nextString, i, chord.getNoteAt(0)).getValue())
                            {
                                foundNoteSix = true;
                                tabChord.setFretNumber(nextString, i.ToString());
                            }
                        }
                        nextString = nextString - 1;
                    }
                }
            }
            else { throw new System.ArgumentException("Tablature building for chord " + chord.getName() + " failed", "tabChordFactory"); }
            return tabChord;
        }
    }
}

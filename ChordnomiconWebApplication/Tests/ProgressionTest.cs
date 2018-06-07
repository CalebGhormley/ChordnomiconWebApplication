using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordnomiconWebApplication
{
    [TestFixture]
    class ProgressionTest
    {
        
        [Test]
        public void ProgressionTest_getChordNames ()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Assert.AreEqual("C", Progression.getChordNames());
            Progression.addChord(ChordFactory.getChordByName("Am7"));
            Assert.AreEqual("C, Am7", Progression.getChordNames());
            Progression.addChord(ChordFactory.getChordByName("G#(add9)"));
            Assert.AreEqual("C, Am7, G#(add9)", Progression.getChordNames());
        }
        [Test]
        public void ProgressionTest_getChord()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Progression.addChord(ChordFactory.getChordByName("Am7"));
            Progression.addChord(ChordFactory.getChordByName("G#(add9)"));
            Assert.AreEqual("A, C, E, G", Progression.getChord(1).getNotes());
        }
        [Test]
        public void ProgressionTest_replaceChord()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Progression.addChord(ChordFactory.getChordByName("Am7"));
            Progression.addChord(ChordFactory.getChordByName("G#(add9)"));
            Progression.replaceChord(0, ChordFactory.getChordByName("Db9"));
            Assert.AreEqual("Db9, Am7, G#(add9)", Progression.getChordNames());
        }
        [Test]
        public void ProgressionTest_swapChords()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Progression.addChord(ChordFactory.getChordByName("Am7"));
            Progression.addChord(ChordFactory.getChordByName("G#(add9)"));
            Progression.swapChords(0, 1);
            Assert.AreEqual("Am7, C, G#(add9)", Progression.getChordNames());
        }
        [Test]
        public void ProgressionTest_removeChord()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Progression.addChord(ChordFactory.getChordByName("Am7"));
            Progression.addChord(ChordFactory.getChordByName("G#(add9)"));
            Progression.removeChord(2);
            Assert.AreEqual("C, Am7", Progression.getChordNames());
        }
        [Test]
        public void ProgressionTest_changeTuning()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("E"));
            Assert.AreEqual("0", Progression.getTabNumber(1, 6));
            Assert.AreEqual("2", Progression.getTabNumber(1, 5));
            Assert.AreEqual("2", Progression.getTabNumber(1, 4));
            Assert.AreEqual("1", Progression.getTabNumber(1, 3));
            Assert.AreEqual("0", Progression.getTabNumber(1, 2));
            Assert.AreEqual("0", Progression.getTabNumber(1, 1));
            Progression.changeTuning(NoteFactory.getNoteByName("E"), NoteFactory.getNoteByName("A"), NoteFactory.getNoteByName("D"),
            NoteFactory.getNoteByName("G#"), NoteFactory.getNoteByName("B"), NoteFactory.getNoteByName("E"));
            Assert.AreEqual("E, A, D, Ab, B, E", Progression.getTuning());
            Assert.AreEqual("0", Progression.getTabNumber(1, 6));
            Assert.AreEqual("2", Progression.getTabNumber(1, 5));
            Assert.AreEqual("2", Progression.getTabNumber(1, 4));
            Assert.AreEqual("0", Progression.getTabNumber(1, 3));
            Assert.AreEqual("0", Progression.getTabNumber(1, 2));
            Assert.AreEqual("0", Progression.getTabNumber(1, 1));
        }
        [Test]
        public void ProgressionTest_getTabNumber()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Assert.AreEqual("X", Progression.getTabNumber(1, 6));
            Assert.AreEqual("3", Progression.getTabNumber(1, 5));
            Assert.AreEqual("2", Progression.getTabNumber(1, 4));
            Assert.AreEqual("0", Progression.getTabNumber(1, 3));
            Assert.AreEqual("1", Progression.getTabNumber(1, 2));
            Assert.AreEqual("0", Progression.getTabNumber(1, 1));
        }
        [Test]
        public void ProgressionTest_changeTabPitch()
        {
            Progression.clearProgression();
            Progression.addChord(ChordFactory.getChordByName("C"));
            Assert.AreEqual("X", Progression.getTabNumber(1, 6));
            Assert.AreEqual("3", Progression.getTabNumber(1, 5));
            Assert.AreEqual("2", Progression.getTabNumber(1, 4));
            Assert.AreEqual("0", Progression.getTabNumber(1, 3));
            Assert.AreEqual("1", Progression.getTabNumber(1, 2));
            Assert.AreEqual("0", Progression.getTabNumber(1, 1));
            Progression.changeTabPitch(1, 2);
            Assert.AreEqual("X", Progression.getTabNumber(1, 6));
            Assert.AreEqual("3", Progression.getTabNumber(1, 5));
            Assert.AreEqual("5", Progression.getTabNumber(1, 4));
            Assert.AreEqual("5", Progression.getTabNumber(1, 3));
            Assert.AreEqual("5", Progression.getTabNumber(1, 2));
            Assert.AreEqual("3", Progression.getTabNumber(1, 1));
        }
    }
}

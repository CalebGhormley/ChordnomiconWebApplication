﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace ChordnomiconWebApplication.Tests
{
    /*
    [TestFixture]
    class NoteFactoryTest
    {
        private Note _note;
        
        [Test]
        public void NoteFactoryTest_getNoteByName()
        {
            _note = NoteFactory.getNoteByName("A");
            Assert.AreEqual(1, _note.getValue());
            _note = NoteFactory.getNoteByName("A#");
            Assert.AreEqual(2, _note.getValue());
            _note = NoteFactory.getNoteByName("Bb");
            Assert.AreEqual(2, _note.getValue());
            _note = NoteFactory.getNoteByName("B");
            Assert.AreEqual(3, _note.getValue());
            _note = NoteFactory.getNoteByName("C");
            Assert.AreEqual(4, _note.getValue());
            _note = NoteFactory.getNoteByName("C#");
            Assert.AreEqual(5, _note.getValue());
            _note = NoteFactory.getNoteByName("Db");
            Assert.AreEqual(5, _note.getValue());
            _note = NoteFactory.getNoteByName("D");
            Assert.AreEqual(6, _note.getValue());
            _note = NoteFactory.getNoteByName("D#");
            Assert.AreEqual(7, _note.getValue());
            _note = NoteFactory.getNoteByName("Eb");
            Assert.AreEqual(7, _note.getValue());
            _note = NoteFactory.getNoteByName("E");
            Assert.AreEqual(8, _note.getValue());
            _note = NoteFactory.getNoteByName("F");
            Assert.AreEqual(9, _note.getValue());
            _note = NoteFactory.getNoteByName("F#");
            Assert.AreEqual(10, _note.getValue());
            _note = NoteFactory.getNoteByName("Gb");
            Assert.AreEqual(10, _note.getValue());
            _note = NoteFactory.getNoteByName("G");
            Assert.AreEqual(11, _note.getValue());
            _note = NoteFactory.getNoteByName("G#");
            Assert.AreEqual(12, _note.getValue());
            _note = NoteFactory.getNoteByName("Ab");
            Assert.AreEqual(12, _note.getValue());
            //private NUnit.Framework.Constraints.IResolveConstraint _expression;
            //private TestDelegate _delegate = new TestDelegate(NoteFactory.getNoteByName("Z"));
            //Assert.Throws(_expression, _delegate);
        }

        [Test]
        public void NoteFactoryTest_getNoteByValue()
        {
            Note _key = NoteFactory.getNoteByName("A");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("A#");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("A#", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("Bb");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("B");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("A#", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("C");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("C#");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("A#", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("Db");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("D");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("D#");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("A#", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("Eb");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("E");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("F");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("F#");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("A#", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("Gb");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("G");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

            _key = NoteFactory.getNoteByName("G#");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("A#", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("C#", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("D#", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("F#", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("G#", _note.getName());

            _key = NoteFactory.getNoteByName("Ab");
            _note = NoteFactory.getNoteByValue(1, _key);
            Assert.AreEqual("A", _note.getName());
            _note = NoteFactory.getNoteByValue(2, _key);
            Assert.AreEqual("Bb", _note.getName());
            _note = NoteFactory.getNoteByValue(3, _key);
            Assert.AreEqual("B", _note.getName());
            _note = NoteFactory.getNoteByValue(4, _key);
            Assert.AreEqual("C", _note.getName());
            _note = NoteFactory.getNoteByValue(5, _key);
            Assert.AreEqual("Db", _note.getName());
            _note = NoteFactory.getNoteByValue(6, _key);
            Assert.AreEqual("D", _note.getName());
            _note = NoteFactory.getNoteByValue(7, _key);
            Assert.AreEqual("Eb", _note.getName());
            _note = NoteFactory.getNoteByValue(8, _key);
            Assert.AreEqual("E", _note.getName());
            _note = NoteFactory.getNoteByValue(9, _key);
            Assert.AreEqual("F", _note.getName());
            _note = NoteFactory.getNoteByValue(10, _key);
            Assert.AreEqual("Gb", _note.getName());
            _note = NoteFactory.getNoteByValue(11, _key);
            Assert.AreEqual("G", _note.getName());
            _note = NoteFactory.getNoteByValue(12, _key);
            Assert.AreEqual("Ab", _note.getName());

        }

    }
    */
}

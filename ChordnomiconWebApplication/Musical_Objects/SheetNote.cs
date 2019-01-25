using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordnomiconWebApplication.Musical_Objects
{
    public class SheetNote : IMusicalElement
    {
        private SheetNote() { }
        public SheetNote(Note n, String d)
        {
            note = n;
            duration = d;
        }
        private Note note { get; }
        private String duration;
        public Note getNote () { return note; }
        public string getDuration () { return duration; }
    }
}
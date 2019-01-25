using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordnomiconWebApplication.Musical_Objects
{
    public class Song
    {
        string name;
        Note key;
        Lyric lyrics;
        Rhythm rhythm;
        Mode mode;
        List<IMusicalElement> musicalElements;

        public Song()
        {
            name = "";
            key = NoteFactory.getNoteByName("C");
            lyrics = new Lyric();
            rhythm = new Rhythm(4, 4);
            mode = ModeFactory.getModeByName("Major");
            musicalElements = new List<IMusicalElement>();
        }


    }
}
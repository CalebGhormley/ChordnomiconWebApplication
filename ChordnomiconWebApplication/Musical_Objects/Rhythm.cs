using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ChordnomiconWebApplication.Musical_Objects
{
    public class Rhythm
    {
        int top, bottom;
        private Rhythm() { }
        public Rhythm(int beatsPerMeasure, int beatUnit)
        {
            top = beatsPerMeasure;
            bottom = beatUnit;
        }
        public int getBeatsPerMeasure() { return top; }
        public int getBeatUnit() { return bottom; }
        public void setBeatsPerMeasure(int beatsPerMeasure) { top = beatsPerMeasure; }
        public void setBeatUnit(int beatUnit) { bottom = beatUnit; }
    }
}
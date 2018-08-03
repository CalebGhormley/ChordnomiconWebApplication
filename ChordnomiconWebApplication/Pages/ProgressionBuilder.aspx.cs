using ChordnomiconWebApplication.Images;
using ChordnomiconWebApplication.Musical_Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChordnomiconWebApplication.Pages
{
    public partial class ProgressionBuilder : System.Web.UI.Page
    {
        Bitmap bitmap;
        int nextNote;
        List<Chord> recomendations = new List<Chord>();
        List<Point> ModalShapePoints = new List<Point>()
        {
            new Point(200, 50),
            new Point(275, 70),
            new Point(330, 125),
            new Point(350, 200),
            new Point(330, 275),
            new Point(275, 330),
            new Point(200, 350),
            new Point(125, 330),
            new Point(70, 275),
            new Point(50, 200),
            new Point(70, 125),
            new Point(125, 70)
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                keyOrMode.Visible = true;
                addChord.Visible = false;
                modifyChord.Visible = false;
                modifyInstrument.Visible = false;
                clearProgression.Visible = false;

                pentatonicModes.Visible = false;
                hexatonicModes.Visible = false;
                heptatonicModes.Visible = true;
                octatonicModes.Visible = false;

            }

            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
            //ChromaticGraphicFactory.drawChromaticGeometry("~/Images/ProgressionChromaticCircle.jpg", ProgressionChromaticCircle);
            
        }

        // -----------------------------------------------------------
        // ----------------Graphic Generating Functions---------------
        //------------------------------------------------------------
        private void drawModalShape()
        {
            bitmap = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(bitmap);

            Font font = new Font(FontFamily.GenericSerif, 18, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Pen blackPen = new Pen(Color.Black, 3);
            Pen grayPen = new Pen(Color.Gray, 5);
            
            string R = Progression.getKey().getName();
            nextNote = Progression.getKey().getValue() + 1;
            if(nextNote > 12) { nextNote = nextNote - 12; }
            string m2 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 2;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string M2 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 3;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string m3 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 4;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string M3 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 5;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string P4 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 6;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string b5 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 7;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string P5 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 8;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string m6 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 9;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string M6 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 10;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string m7 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();
            nextNote = Progression.getKey().getValue() + 11;
            if (nextNote > 12) { nextNote = nextNote - 12; }
            string M7 = NoteFactory.getNoteByValue(nextNote, Progression.getKey()).getName();

            g.Clear(Color.White);
            g.DrawEllipse(grayPen, 50, 50, 300, 300);
            g.DrawEllipse(blackPen, 50, 50, 300, 300);

            int firstPoint = 0;
            int secondPoint = 0;
            for (int i = 0; i < Progression.getMode().getSize(); i++)
            {
                for (int j = 0; j < (Progression.getMode().getSize() - i); j++)
                {
                    secondPoint = Progression.getMode().getIntervalValue(j + i);
                    g.DrawLine(Progression.getMode().getPen(), ModalShapePoints.ElementAt(firstPoint), ModalShapePoints.ElementAt(secondPoint));
                }
                firstPoint = Progression.getMode().getIntervalValue(i);
            }
            g.DrawLine(Progression.getMode().getPen(), ModalShapePoints.ElementAt(firstPoint), ModalShapePoints.ElementAt(0));

            g.DrawString(R, font, Brushes.Black, new RectangleF(175, 10, 50, 40), stringFormat);
            g.DrawString(m2, font, Brushes.Black, new RectangleF(270, 30, 50, 40), stringFormat);
            g.DrawString(M2, font, Brushes.Black, new RectangleF(325, 85, 50, 40), stringFormat);
            g.DrawString(m3, font, Brushes.Black, new RectangleF(345, 180, 50, 40), stringFormat);
            g.DrawString(M3, font, Brushes.Black, new RectangleF(325, 275, 50, 40), stringFormat);
            g.DrawString(P4, font, Brushes.Black, new RectangleF(270, 330, 50, 40), stringFormat);
            g.DrawString(b5, font, Brushes.Black, new RectangleF(175, 350, 50, 40), stringFormat);
            g.DrawString(P5, font, Brushes.Black, new RectangleF(80, 330, 50, 40), stringFormat);
            g.DrawString(m6, font, Brushes.Black, new RectangleF(25, 275, 50, 40), stringFormat);
            g.DrawString(M6, font, Brushes.Black, new RectangleF(5, 180, 50, 40), stringFormat);
            g.DrawString(m7, font, Brushes.Black, new RectangleF(25, 85, 50, 40), stringFormat);
            g.DrawString(M7, font, Brushes.Black, new RectangleF(80, 30, 50, 40), stringFormat);

            for (int i = 0; i < Progression.getSize(); i++)
            {
                g.FillPolygon(Progression.getChord(i).color, Progression.getChordPolygon(i));
            }
            
            string path = Server.MapPath("~/Images/ProgressionChromaticCircle.jpg");
            bitmap.Save(path, ImageFormat.Jpeg);
            ProgressionChromaticCircle.ImageUrl = "~/Images/ProgressionChromaticCircle.jpg";
            g.Dispose();
            bitmap.Dispose();
        }

        private void drawTablature()
        {
            int SheetSizeOffset = 0;
            int SheetLength;
            if (Progression.getSize() > 12) { SheetSizeOffset = (Progression.getSize() - 12) * 200; }
            SheetLength = 2800 + SheetSizeOffset;
            bitmap = new Bitmap(SheetLength, 450);
            Graphics g = Graphics.FromImage(bitmap);

            Font keyFont = new Font(FontFamily.GenericSerif, 50, FontStyle.Italic);
            Font modeFont = new Font(FontFamily.GenericSerif, 28);
            Font tabFont = new Font(FontFamily.GenericSerif, 70, FontStyle.Bold);
            Font font = new Font(FontFamily.GenericSansSerif, 34, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Pen blackPen = new Pen(Color.Black, 3);

            g.Clear(Color.White);

            g.DrawString("T", tabFont, Brushes.Black, new RectangleF(25, 55, 75, 80), stringFormat);
            g.DrawString("A", tabFont, Brushes.Black, new RectangleF(25, 135, 75, 80), stringFormat);
            g.DrawString("B", tabFont, Brushes.Black, new RectangleF(25, 225, 75, 80), stringFormat);

            for(int i = 0; i < Progression.getSize(); i++)
            {
                for (int j = 0; j < Progression.getGuitar().getNumberOfStrings(); j++)
                {
                    g.DrawString(Progression.getTabNumber(i, j + 1), font, Brushes.Black, new Rectangle(400 + (i * 200), 23 + (j * 50), 65, 50), stringFormat);
                }
            }

            for(int i = 0; i < Progression.getSize(); i++)
            {
                g.FillRectangle(Progression.getChord(i).color, new Rectangle(360 + (i * 200), 435, 180, 445));
                g.DrawString(Progression.getChord(i).getName(), font, Brushes.Black, new Rectangle(350 + (i * 200), 380, 200, 70), stringFormat);
                
            }

            for (int i = 1; i <= Progression.getGuitar().getNumberOfStrings(); i++)
            {
                g.DrawLine(blackPen, 0, 50 * i, 2800 + (SheetSizeOffset * 200), 50 * i);
            }

            g.DrawString(Progression.getKey().getName(), keyFont, Brushes.Black, new RectangleF(50, 325, 200, 100), stringFormat);
            if (Progression.getMode() != null)
            {
                g.FillRectangle(Progression.getMode().getBrush(), new Rectangle(10, 440, 290, 450));
                g.DrawString(Progression.getMode().getName(), modeFont, Brushes.Black, new RectangleF(0, 400, 300, 50), stringFormat);
            }

            string path = Server.MapPath("~/Images/ProgressionSheetMusic.jpg");
            bitmap.Save(path, ImageFormat.Jpeg);
            ProgressionSheetMusic.ImageUrl = "~/Images/ProgressionSheetMusic.jpg";
            g.Dispose();
            bitmap.Dispose();
        }

        private void drawSheetMusic()
        {
            bool isTrebleClef = true;
            bool isBassClef = false;
            bool isAltoClef = false;

            bool hasFirstSharp = false;
            bool hasSecondSharp = false;
            bool hasThirdSharp = false;
            bool hasFourthSharp = false;
            bool hasFifthSharp = false;
            bool hasSixthSharp = false;
            bool hasSeventhSharp = false;

            bool hasFirstSharpAccidental = false;
            bool hasSecondSharpAccidental = false;
            bool hasThirdSharpAccidental = false;
            bool hasFourthSharpAccidental = false;
            bool hasFifthSharpAccidental = false;
            bool hasSixthSharpAccidental = false;
            bool hasSeventhSharpAccidental = false;

            bool hasFirstFlat = false;
            bool hasSecondFlat = false;
            bool hasThirdFlat = false;
            bool hasFourthFlat = false;
            bool hasFifthFlat = false;
            bool hasSixthFlat = false;
            bool hasSeventhFlat = false;

            bool hasFirstFlatAccidental = false;
            bool hasSecondFlatAccidental = false;
            bool hasThirdFlatAccidental = false;
            bool hasFourthFlatAccidental = false;
            bool hasFifthFlatAccidental = false;
            bool hasSixthFlatAccidental = false;
            bool hasSeventhFlatAccidental = false;

            int SheetSizeOffset = 0;
            int SheetLength;
            if (Progression.getSize() > 12)
            {
                SheetSizeOffset = (Progression.getSize() - 12) * 200;
            }
            SheetLength = 2800 + SheetSizeOffset;
            bitmap = new Bitmap(SheetLength, 450);
            Graphics g = Graphics.FromImage(bitmap);

            Font keyFont = new Font(FontFamily.GenericSerif, 50, FontStyle.Italic);
            Font modeFont = new Font(FontFamily.GenericSerif, 28);
            Font font = new Font(FontFamily.GenericSerif, 34, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Pen blackPen = new Pen(Color.Black, 3);

            g.Clear(Color.White);

            string key = Progression.getKey().getName();
            string mode = Progression.getMode().getName();

            if (isTrebleClef) { g.DrawImage(Properties.Resources.TrebleClef, 5, 45, 140, 325); } 
            else if (isBassClef) { g.DrawImage(Properties.Resources.BassClef, 5, 95, 150, 175); }
            else if (isAltoClef) { g.DrawImage(Properties.Resources.AltoClef, 5, 100, 130, 200); }

            if (isTrebleClef)
            {
                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("F#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("F"), Progression.getKey())))
                { hasFirstSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("F#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("F"), Progression.getKey()))
                { hasFirstSharpAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("C#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("C"), Progression.getKey())))
                { hasSecondSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("C#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("C"), Progression.getKey()))
                { hasSecondSharpAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("G#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("G"), Progression.getKey())))
                { hasThirdSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("G#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("G"), Progression.getKey()))
                { hasThirdSharpAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("D#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("D"), Progression.getKey())))
                { hasFourthSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("D#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("D"), Progression.getKey()))
                { hasFourthSharpAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("A#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("A"), Progression.getKey())))
                { hasFifthSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("A#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("A"), Progression.getKey()))
                { hasFifthSharpAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("E#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("E"), Progression.getKey())))
                { hasSixthSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("E#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("E"), Progression.getKey()))
                { hasSixthSharpAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("B#"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("B"), Progression.getKey())))
                { hasSeventhSharp = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("B#"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("B"), Progression.getKey()))
                { hasSeventhSharpAccidental = true; }
                
                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Bb"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("B"), Progression.getKey())))
                { hasFirstFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Bb"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("B"), Progression.getKey()))
                { hasFirstFlatAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Eb"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("E"), Progression.getKey())))
                { hasSecondFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Eb"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("E"), Progression.getKey()))
                { hasSecondFlatAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Ab"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("A"), Progression.getKey())))
                { hasThirdFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Ab"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("A"), Progression.getKey()))
                { hasThirdFlatAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Db"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("D"), Progression.getKey())))
                { hasFourthFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Db"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("D"), Progression.getKey()))
                { hasFourthFlatAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Gb"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("G"), Progression.getKey())))
                { hasFifthFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Gb"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("G"), Progression.getKey()))
                { hasFifthFlatAccidental = true; }

                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Cb"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("C"), Progression.getKey())))
                { hasSixthFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Cb"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("C"), Progression.getKey()))
                { hasSixthFlatAccidental = true; }
                
                if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Fb"), Progression.getKey()) && !(Progression.getMode().containsNoteName(NoteFactory.getNoteByName("F"), Progression.getKey())))
                { hasSeventhFlat = true; }
                else if (Progression.getMode().containsNoteName(NoteFactory.getNoteByName("Fb"), Progression.getKey()) && Progression.getMode().containsNoteName(NoteFactory.getNoteByName("F"), Progression.getKey()))
                { hasSeventhFlatAccidental = true; }

            }

            bool firstTopBar = false;
            bool secondTopBar = false;
            bool thirdTopBar = false;
            //bool fourthTopBar = false;

            bool firstBottomBar = false;
            bool secondBottomBar = false;
            bool thirdBottomBar = false;
            //bool fourthBottomBar = false;

            Note startingNote;
            

            int startingPosition;
            bool found;
            int counter;
            int staffLineOffset;
            int noteValueOffset;
            for (int i = 0; i < Progression.getSize(); i++)
            {
                if (Progression.getChord(i).getSize() <= 4)
                {
                    startingPosition = 275;
                    if (isTrebleClef)
                    {
                        if (NoteFactory.getNoteByValue(8, Progression.getKey()).getName() == "Fb") { startingNote = NoteFactory.getNoteByName("Eb"); }
                        else { startingNote = NoteFactory.getNoteByName("E"); }
                    }
                    else if (isBassClef)
                    {
                        if (NoteFactory.getNoteByValue(4, Progression.getKey()).getName() == "B#") { startingNote = NoteFactory.getNoteByName("C#"); }
                        else { startingNote = NoteFactory.getNoteByName("C"); }
                    }
                    else
                    {
                        if (NoteFactory.getNoteByValue(4, Progression.getKey()).getName() == "B#") { startingNote = NoteFactory.getNoteByName("C#"); }
                        else { startingNote = NoteFactory.getNoteByName("C"); }
                    }
                }
                else
                {
                    startingPosition = 325;
                    if (isTrebleClef)
                    {
                        if (NoteFactory.getNoteByValue(4, Progression.getKey()).getName() == "B#") { startingNote = NoteFactory.getNoteByName("C#"); }
                        else { startingNote = NoteFactory.getNoteByName("C"); }
                    }
                    else if (isBassClef)
                    {
                        if (NoteFactory.getNoteByValue(4, Progression.getKey()).getName() == "B#") { startingNote = NoteFactory.getNoteByName("C#"); }
                        else { startingNote = NoteFactory.getNoteByName("D"); }
                    }
                    else
                    {
                        if (NoteFactory.getNoteByValue(4, Progression.getKey()).getName() == "B#") { startingNote = NoteFactory.getNoteByName("C#"); }
                        else { startingNote = NoteFactory.getNoteByName("C"); }
                    }
                }
                counter = 0;
                staffLineOffset = 0;
                int lastFoundStaffLine = 100;
                for (int j = 0; j < Progression.getChord(i).getSize(); j++)
                {
                    found = false;
                    char[] noteChars = Progression.getChord(i).getNoteAt(j).getName().ToCharArray();
                    while (!found)
                    {
                        noteValueOffset = (startingNote.getValue() + counter);
                        while (noteValueOffset > 12) { noteValueOffset = noteValueOffset - 12; }
                        if (Progression.getChord(i).getNoteAt(j).getValue() == NoteFactory.getNoteByValue(noteValueOffset, Progression.getKey()).getValue() ||
                            (noteChars.Length > 1 && noteChars[1] == '#' && (Progression.getChord(i).getNoteAt(j).getValue() == NoteFactory.getNoteByValue(noteValueOffset, Progression.getKey()).getValue() + 1)))
                        {
                            found = true;
                            if (staffLineOffset == lastFoundStaffLine + 1)
                            {
                                g.DrawImage(Properties.Resources.WholeNote, new Rectangle((400 + 65 + (i * 200)), (startingPosition - (staffLineOffset * 25)), 65, 50));
                            }
                            else { g.DrawImage(Properties.Resources.WholeNote, new Rectangle((400 + (i * 200)), (startingPosition - (staffLineOffset * 25)), 65, 50)); }
                            if (!(Progression.getMode().containsNoteName(Progression.getChord(i).getNoteAt(j), Progression.getKey())))
                            {
                                char[] chordChars = Progression.getChord(i).getNoteAt(j).getName().ToCharArray();
                                if (chordChars.Length == 1)
                                {
                                    g.DrawImage(Properties.Resources.NaturalSign, new Rectangle((370 + (i * 200)), (startingPosition - (staffLineOffset * 25)), 25, 50));
                                }
                                else if (chordChars.Length == 2 && chordChars[1] == '#')
                                {
                                    g.DrawImage(Properties.Resources.SharpSign, new Rectangle((350 + (i * 200)), (startingPosition - 10 - (staffLineOffset * 25)), 40, 60));
                                }
                                else if (chordChars.Length == 2 && chordChars[1] == 'b')
                                {
                                    g.DrawImage(Properties.Resources.FlatSign, new Rectangle((370 + (i * 200)), (startingPosition - 15 - (staffLineOffset * 25)), 25, 70));
                                }
                            }
                            lastFoundStaffLine = staffLineOffset; 
                        }
                        else
                        {
                            int nextNoteValueOffset = noteValueOffset + 1;
                            if (nextNoteValueOffset > 12) { nextNoteValueOffset = nextNoteValueOffset - 12; }
                            char[] currentNoteChars = NoteFactory.getNoteByValue(noteValueOffset, Progression.getKey()).getName().ToCharArray();
                            char[] nextNoteChars = NoteFactory.getNoteByValue(nextNoteValueOffset, Progression.getKey()).getName().ToCharArray();
                            if (currentNoteChars[0] != nextNoteChars[0]) { staffLineOffset = staffLineOffset + 1; }
                            counter = counter + 1;
                        }
                    }
                }
            }
            
            Rectangle firstSharp = new Rectangle(130, 70, 40, 60);
            Rectangle secondSharp = new Rectangle(160, 145, 40, 60);
            Rectangle thirdSharp = new Rectangle(190, 45, 40, 60);
            Rectangle fourthSharp = new Rectangle(220, 120, 40, 60);
            Rectangle fifthSharp = new Rectangle(250, 195, 40, 60);
            Rectangle sixthSharp = new Rectangle(280, 95, 40, 60);
            Rectangle seventhSharp = new Rectangle(310, 170, 40, 60);

            Rectangle firstFlat = new Rectangle(140, 155, 25, 70);
            Rectangle secondFlat = new Rectangle(165, 80, 25, 70);
            Rectangle thirdFlat = new Rectangle(190, 180, 25, 70);
            Rectangle fourthFlat = new Rectangle(215, 105, 25, 70);
            Rectangle fifthFlat = new Rectangle(240, 205, 25, 70);
            Rectangle sixthFlat = new Rectangle(265, 130, 25, 70);
            Rectangle seventhFlat = new Rectangle(290, 230, 25, 70);
            
            if (isTrebleClef)
            {
                g.DrawImage(Properties.Resources.TrebleClef, 5, 45, 140, 325);
            }
            else if (isBassClef)
            {
                g.DrawImage(Properties.Resources.BassClef, 5, 95, 150, 175);
            }
            else
            {
                g.DrawImage(Properties.Resources.AltoClef, 5, 100, 130, 200);
            }

            if (hasFirstSharp) { g.DrawImage(Properties.Resources.SharpSign, firstSharp); }
            if (hasSecondSharp) { g.DrawImage(Properties.Resources.SharpSign, secondSharp); }
            if (hasThirdSharp) { g.DrawImage(Properties.Resources.SharpSign, thirdSharp); }
            if (hasFourthSharp) { g.DrawImage(Properties.Resources.SharpSign, fourthSharp); }
            if (hasFifthSharp) { g.DrawImage(Properties.Resources.SharpSign, fifthSharp); }
            if (hasSixthSharp) { g.DrawImage(Properties.Resources.SharpSign, sixthSharp); }
            if (hasSeventhSharp) { g.DrawImage(Properties.Resources.SharpSign, seventhSharp); }

            if (hasFirstFlat) { g.DrawImage(Properties.Resources.FlatSign, firstFlat); }
            if (hasSecondFlat) { g.DrawImage(Properties.Resources.FlatSign, secondFlat); }
            if (hasThirdFlat) { g.DrawImage(Properties.Resources.FlatSign, thirdFlat); }
            if (hasFourthFlat) { g.DrawImage(Properties.Resources.FlatSign, fourthFlat); }
            if (hasFifthFlat) { g.DrawImage(Properties.Resources.FlatSign, fifthFlat); }
            if (hasSixthFlat) { g.DrawImage(Properties.Resources.FlatSign, sixthFlat); }
            if (hasSeventhFlat) { g.DrawImage(Properties.Resources.FlatSign, seventhFlat); }
            
            g.DrawLine(blackPen, 0, 100, 2800, 100);
            g.DrawLine(blackPen, 0, 150, 2800, 150);
            g.DrawLine(blackPen, 0, 200, 2800, 200);
            g.DrawLine(blackPen, 0, 250, 2800, 250);
            g.DrawLine(blackPen, 0, 300, 2800, 300);

            g.DrawLine(blackPen, 550, 100, 550, 300);
            g.DrawLine(blackPen, 750, 100, 750, 300);
            g.DrawLine(blackPen, 950, 100, 950, 300);
            g.DrawLine(blackPen, 1150, 100, 1150, 300);
            g.DrawLine(blackPen, 1350, 100, 1350, 300);
            g.DrawLine(blackPen, 1550, 100, 1550, 300);
            g.DrawLine(blackPen, 1750, 100, 1750, 300);
            g.DrawLine(blackPen, 1950, 100, 1950, 300);
            g.DrawLine(blackPen, 2150, 100, 2150, 300);
            g.DrawLine(blackPen, 2350, 100, 2350, 300);
            g.DrawLine(blackPen, 2550, 100, 2550, 300);
            g.DrawLine(blackPen, 2750, 100, 2750, 300);
            g.FillRectangle(Brushes.Black, new Rectangle(2775, 100, 25, 200));

            if (firstTopBar) { g.DrawLine(blackPen, 385, 50, 480, 50); }
            if (secondTopBar) { g.DrawLine(blackPen, 585, 50, 680, 50); }
            if (thirdTopBar) { g.DrawLine(blackPen, 785, 50, 880, 50); }
            //if (fourthTopBar) { g.DrawLine(blackPen, 985, 50, 1080, 50); }

            if (firstBottomBar) { g.DrawLine(blackPen, 385, 350, 480, 350); }
            if (secondBottomBar) { g.DrawLine(blackPen, 585, 350, 680, 350); }
            if (thirdBottomBar) { g.DrawLine(blackPen, 785, 350, 880, 350); }
            //if (fourthBottomBar) { g.DrawLine(blackPen, 985, 350, 1080, 350); }

            for (int i = 0; i < Progression.getSize(); i++)
            {
                g.FillRectangle(Progression.getChord(i).color, new Rectangle(360 + (i * 200), 435, 180, 445));
                g.DrawString(Progression.getChord(i).getName(), font, Brushes.Black, new Rectangle(350 + (i * 200), 380, 200, 70), stringFormat);

            }

            g.DrawString(Progression.getKey().getName(), keyFont, Brushes.Black, new RectangleF(50, 325, 200, 100), stringFormat);
            g.DrawString(Progression.getMode().getName(), modeFont, Brushes.Black, new RectangleF(0, 400, 300, 50), stringFormat);
            
            string path = Server.MapPath("~/Images/ProgressionSheetMusic.jpg");
            bitmap.Save(path, ImageFormat.Jpeg);
            ProgressionSheetMusic.ImageUrl = "~/Images/ProgressionSheetMusic.jpg";
            g.Dispose();
            bitmap.Dispose();
        }

        protected void RadioButtonTabOrSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------
        //--------------------Option Navigation Buttons---------------
        //------------------------------------------------------------
        protected void keyOrModeOptions_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = true;
            addChord.Visible = false;
            modifyChord.Visible = false;
            modifyInstrument.Visible = false;
            clearProgression.Visible = false;
        }

        protected void addChordOptions_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = false;
            addChord.Visible = true;
            modifyChord.Visible = false;
            modifyInstrument.Visible = false;
            clearProgression.Visible = false;
            recomendations = ChordFactory.getChordRecomendationsTriads(Progression.getKey(), Progression.getMode());
        }

        protected void modifyChordOptions_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = false;
            addChord.Visible = false;
            modifyChord.Visible = true;
            modifyInstrument.Visible = false;
            clearProgression.Visible = false;
        }

        protected void modifyInstrumentOptions_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = false;
            addChord.Visible = false;
            modifyChord.Visible = false;
            modifyInstrument.Visible = true;
            clearProgression.Visible = false;
        }

        protected void clearProgressionOtions_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = false;
            addChord.Visible = false;
            modifyChord.Visible = false;
            modifyInstrument.Visible = false;
            clearProgression.Visible = true;
        }

        //------------------------------------------------------------
        //-----------------Key Modifying Functions--------------------
        //------------------------------------------------------------
        protected void KeyEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteController.checkNoteName(KeyEntryBox.Text))
            {
                Progression.changeKey(NoteFactory.getNoteByName(KeyEntryBox.Text));
                drawModalShape();
                if (RadioButtonTabOrSheet.SelectedIndex == 0)
                {
                    drawSheetMusic();
                }
                else
                {
                    drawTablature();
                }
            }
        }

        protected void KeyEntryButton_Click(object sender, EventArgs e)
        {
            if (Progression.getKey() != null)
            {
                KeyEntryLabel.Text = "The current key is: " + Progression.getKey().getName();
            }
            else { KeyEntryLabel.Text = "Please select a valid key name"; }
        }

        protected void KeyEntryDropdownButton_Click(object sender, EventArgs e)
        {
            if (KeyDropDownList.SelectedIndex == 1) { Progression.changeKey(NoteFactory.getNoteByName("Ab")); }
            else if (KeyDropDownList.SelectedIndex == 2) { Progression.changeKey(NoteFactory.getNoteByName("A")); }
            else if (KeyDropDownList.SelectedIndex == 3) { Progression.changeKey(NoteFactory.getNoteByName("A#")); }
            else if (KeyDropDownList.SelectedIndex == 4) { Progression.changeKey(NoteFactory.getNoteByName("Bb")); }
            else if (KeyDropDownList.SelectedIndex == 5) { Progression.changeKey(NoteFactory.getNoteByName("B")); }
            else if (KeyDropDownList.SelectedIndex == 6) { Progression.changeKey(NoteFactory.getNoteByName("C")); }
            else if (KeyDropDownList.SelectedIndex == 7) { Progression.changeKey(NoteFactory.getNoteByName("C#")); }
            else if (KeyDropDownList.SelectedIndex == 8) { Progression.changeKey(NoteFactory.getNoteByName("Db")); }
            else if (KeyDropDownList.SelectedIndex == 9) { Progression.changeKey(NoteFactory.getNoteByName("D")); }
            else if (KeyDropDownList.SelectedIndex == 10) { Progression.changeKey(NoteFactory.getNoteByName("D#")); }
            else if (KeyDropDownList.SelectedIndex == 11) { Progression.changeKey(NoteFactory.getNoteByName("Eb")); }
            else if (KeyDropDownList.SelectedIndex == 12) { Progression.changeKey(NoteFactory.getNoteByName("E")); }
            else if (KeyDropDownList.SelectedIndex == 13) { Progression.changeKey(NoteFactory.getNoteByName("F")); }
            else if (KeyDropDownList.SelectedIndex == 14) { Progression.changeKey(NoteFactory.getNoteByName("F#")); }
            else if (KeyDropDownList.SelectedIndex == 15) { Progression.changeKey(NoteFactory.getNoteByName("Gb")); }
            else if (KeyDropDownList.SelectedIndex == 16) { Progression.changeKey(NoteFactory.getNoteByName("G")); }
            else if (KeyDropDownList.SelectedIndex == 17) { Progression.changeKey(NoteFactory.getNoteByName("G#")); }
            else { }

            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        protected void KeyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------
        //----------------Mode Modifying Functions--------------------
        //------------------------------------------------------------
        protected void ModeEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (ModeController.checkModeName(ModeEntryBox.Text))
            {
                Progression.changeMode(ModeEntryBox.Text);
                drawModalShape();
                if (RadioButtonTabOrSheet.SelectedIndex == 0)
                {
                    drawSheetMusic();
                }
                else
                {
                    drawTablature();
                }
            }
        }

        protected void ModeEntryButton_Click(object sender, EventArgs e)
        {
            if (Progression.getMode() != null)
            {
                ModeEntryLabel.Text = "The current mode is: " + Progression.getMode().getName();
            }
            else { KeyEntryLabel.Text = "Please select a valid mode name"; }
        }

        protected void ModeToneDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void PentatonicDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void HexatonicDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void HeptatonicDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void OctsatonicDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ModeTypeButton_Click(object sender, EventArgs e)
        {
            if (ModeToneDropDownList.SelectedIndex == 0)
            {
                pentatonicModes.Visible = true;
                hexatonicModes.Visible = false;
                heptatonicModes.Visible = false;
                octatonicModes.Visible = false;
            }
            else if (ModeToneDropDownList.SelectedIndex == 1)
            {
                pentatonicModes.Visible = false;
                hexatonicModes.Visible = true;
                heptatonicModes.Visible = false;
                octatonicModes.Visible = false;
            }
            else if (ModeToneDropDownList.SelectedIndex == 2)
            {
                pentatonicModes.Visible = false;
                hexatonicModes.Visible = false;
                heptatonicModes.Visible = true;
                octatonicModes.Visible = false;
            }
            else if (ModeToneDropDownList.SelectedIndex == 3)
            {
                pentatonicModes.Visible = false;
                hexatonicModes.Visible = false;
                heptatonicModes.Visible = false;
                octatonicModes.Visible = true;
            }
        }

        protected void PentatonicModeDropDownEntryButton_Click(object sender, EventArgs e)
        {
            if (PentatonicDropDownList.SelectedIndex == 0) { Progression.changeMode("Blues Major"); }
            else if (PentatonicDropDownList.SelectedIndex == 1) { Progression.changeMode("Pentatonic Major"); }
            else if (PentatonicDropDownList.SelectedIndex == 2) { Progression.changeMode("Suspended"); }
            else if (PentatonicDropDownList.SelectedIndex == 3) { Progression.changeMode("Pentatonic Minor"); }
            else if (PentatonicDropDownList.SelectedIndex == 4) { Progression.changeMode("Blues Minor"); }

            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        protected void HexatonicModeDropDownEntryButton_Click(object sender, EventArgs e)
        {


            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        protected void HeptatonicModeDropDownEntryButton_Click(object sender, EventArgs e)
        {
            if (HeptatonicDropDownList.SelectedIndex == 0) { Progression.changeMode("Lydian"); }
            else if (HeptatonicDropDownList.SelectedIndex == 1) { Progression.changeMode("Ionian"); }
            else if (HeptatonicDropDownList.SelectedIndex == 2) { Progression.changeMode("Mixolydian"); }
            else if (HeptatonicDropDownList.SelectedIndex == 3) { Progression.changeMode("Dorian"); }
            else if (HeptatonicDropDownList.SelectedIndex == 4) { Progression.changeMode("Aeolian"); }
            else if (HeptatonicDropDownList.SelectedIndex == 5) { Progression.changeMode("Phrygian"); }
            else if (HeptatonicDropDownList.SelectedIndex == 6) { Progression.changeMode("Locrian"); }

            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        protected void OctatonicModeDropDownEntryButton_Click(object sender, EventArgs e)
        {


            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        //-------------------------------------------------------------
        //---------------------Chord Add Functions---------------------
        //-------------------------------------------------------------
        protected void ChordEntryButton_Click(object sender, EventArgs e)
        {
            
            if (ChordController.checkChordName(ChordEntryBox.Text))
            {
                ChordEntryLabel.Text = "The current chords in your progression are: " + Progression.getChordNames();
            }
            else { ChordEntryLabel.Text = "Please select a valid chord name"; }

        }

        protected void ChordEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (ChordController.checkChordName(ChordEntryBox.Text))
            {
                Progression.addChord(ChordFactory.getChordByName(ChordEntryBox.Text));
                CreateChordPointArray(Progression.getChord(Progression.getSize() - 1));
                RemoveChordDropDownList.Items.Add(new ListItem(ChordEntryBox.Text));
                SwitchFirstChordDropDownList.Items.Add(new ListItem(ChordEntryBox.Text));
                SwitchSecondDropDownList.Items.Add(new ListItem(ChordEntryBox.Text));
                drawModalShape();
                if (RadioButtonTabOrSheet.SelectedIndex == 0)
                {
                    drawSheetMusic();
                }
                else
                {
                    drawTablature();
                }
            }
        }

        protected void RecommendedChordDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RecommendedChordsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------
        //-------------------Chord Modifying Functions----------------
        //------------------------------------------------------------
        protected void SwitchFirstChordDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SwitchSecondDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SwitchChordsButton_Click(object sender, EventArgs e)
        {
            if (SwitchFirstChordDropDownList.SelectedIndex >= 1 && SwitchSecondDropDownList.SelectedIndex >= 1)
            {
                int i = SwitchFirstChordDropDownList.SelectedIndex;
                int j = SwitchSecondDropDownList.SelectedIndex;
                Progression.swapChords(i - 1, j - 1);
                String tempOne = SwitchFirstChordDropDownList.SelectedItem.Text;
                String tempTwo = SwitchSecondDropDownList.SelectedItem.Text;
                SwapItemsInDynamicLists(i, tempOne, j, tempTwo);
            }

            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        protected void ChordPitchDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RaiseChordPitchButton_Click(object sender, EventArgs e)
        {

        }

        protected void LowerChordPitchButton_Click(object sender, EventArgs e)
        {

        }

        protected void RemoveChordDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ReplaceChordDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ReplaceChordEntryBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ReplaceChordEntryButton_Click(object sender, EventArgs e)
        {

        }

        protected void RemoveChordButton_Click(object sender, EventArgs e)
        {
            if (RemoveChordDropDownList.SelectedIndex >= 1)
            {
                int i = RemoveChordDropDownList.SelectedIndex;
                Progression.removeChord(i - 1);
                RemoveItemFromDynamicLists(i - 1);
            }

            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0) { drawSheetMusic(); }
            else { drawTablature(); }
        }

        //-------------------------------------------------------------
        //-----------------Instrument Modifying Options----------------
        //-------------------------------------------------------------
        protected void InstrumentDrowDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void FirstStringDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void FourthStringDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SecondStringDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void FifthStringDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ThirdStringDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SixthStringDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------
        //-------------------Clear Progression Functions---------------
        //-------------------------------------------------------------
        protected void clearProgFunction(object sender, EventArgs e)
        {
            Progression.clearProgression();
        }

        protected void yesClearButton_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = true;
            addChord.Visible = false;
            modifyChord.Visible = false;
            modifyInstrument.Visible = false;
            clearProgression.Visible = false;

            for (int i = 0; i < Progression.getSize(); i++)
            {
                RemoveItemFromDynamicLists(i);
            }
            Progression.clearProgression();
            drawModalShape();
            if (RadioButtonTabOrSheet.SelectedIndex == 0)
            {
                drawSheetMusic();
            }
            else
            {
                drawTablature();
            }
            
        }

        protected void noClearButton_Click(object sender, EventArgs e)
        {
            keyOrMode.Visible = true;
            addChord.Visible = false;
            modifyChord.Visible = false;
            modifyInstrument.Visible = false;
            clearProgression.Visible = false;
        }

        //-------------------------------------------------------------
        //------------------Private Helper Functions-------------------
        //-------------------------------------------------------------
        private void CreateChordPointArray(Chord chord)
        {
            Point[] polygonPointArray = new Point[chord.getSize()];
            int tonicValue = Progression.getKey().getValue();
            int noteValueOffset;
            int polygonSize = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < chord.getSize(); j++)
                {
                    noteValueOffset = tonicValue + i;
                    if (noteValueOffset > 12) { noteValueOffset = noteValueOffset - 12; }
                    if (chord.getNoteAt(j).getValue() == noteValueOffset)
                    {
                        polygonPointArray[polygonSize] = ModalShapePoints.ElementAt(i);
                        polygonSize++;
                    }
                }
            }
            Progression.addChordPolygon(polygonPointArray);
        }
        
        /// <summary>
        /// Removes the chord from all dynamic lists, position is the position in the progression not the dynamic lists
        /// </summary>
        /// <param name="position"></param>
        private void RemoveItemFromDynamicLists (int position)
        {
            RemoveChordDropDownList.Items.RemoveAt(position + 1);
            SwitchFirstChordDropDownList.Items.RemoveAt(position + 1);
            SwitchSecondDropDownList.Items.RemoveAt(position + 1);
            Progression.removeChordPolygon(position);
            
        }

        private void SwapItemsInDynamicLists (int positionOne, string itemOne, int positionTwo, string itemTwo)
        {
            SwitchFirstChordDropDownList.Items.RemoveAt(positionOne);
            SwitchFirstChordDropDownList.Items.Insert(positionOne, itemTwo);
            SwitchFirstChordDropDownList.Items.RemoveAt(positionTwo);
            SwitchFirstChordDropDownList.Items.Insert(positionTwo, itemOne);
            
            SwitchSecondDropDownList.Items.RemoveAt(positionTwo);
            SwitchSecondDropDownList.Items.Insert(positionTwo, itemOne);
            SwitchSecondDropDownList.Items.RemoveAt(positionOne);
            SwitchSecondDropDownList.Items.Insert(positionOne, itemTwo);

            RemoveChordDropDownList.Items.RemoveAt(positionOne);
            RemoveChordDropDownList.Items.Insert(positionOne, itemTwo);
            RemoveChordDropDownList.Items.RemoveAt(positionTwo);
            RemoveChordDropDownList.Items.Insert(positionTwo, itemOne);

            Point[] tempPolygon = Progression.getChordPolygon(positionOne - 1);
            Progression.changeChordPolygon(positionOne - 1, Progression.getChordPolygon(positionTwo - 1));
            Progression.changeChordPolygon(positionTwo - 1, tempPolygon);
        }
    }
}
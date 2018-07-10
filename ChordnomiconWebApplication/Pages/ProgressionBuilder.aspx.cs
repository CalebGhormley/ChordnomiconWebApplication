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
        bool tabOrSheet = false;
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

                drawModalShape();

                
            }


            if (tabOrSheet)
            {
                drawTablature();
            }
            else
            {
                drawSheetMusic();
            }
            //ChromaticGraphicFactory.drawChromaticGeometry("~/Images/ProgressionChromaticCircle.jpg", ProgressionChromaticCircle);
        }
        
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
            Pen goldPen = new Pen(Color.Gold, 3);
            
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
                    g.DrawLine(goldPen, ModalShapePoints.ElementAt(firstPoint), ModalShapePoints.ElementAt(secondPoint));
                }
                firstPoint = Progression.getMode().getIntervalValue(i);
            }
            g.DrawLine(goldPen, ModalShapePoints.ElementAt(firstPoint), ModalShapePoints.ElementAt(0));

            g.DrawString(R, font, Brushes.Black, new RectangleF(180, 10, 40, 40), stringFormat);
            g.DrawString(m2, font, Brushes.Black, new RectangleF(275, 30, 40, 40), stringFormat);
            g.DrawString(M2, font, Brushes.Black, new RectangleF(330, 85, 40, 40), stringFormat);
            g.DrawString(m3, font, Brushes.Black, new RectangleF(350, 180, 40, 40), stringFormat);
            g.DrawString(M3, font, Brushes.Black, new RectangleF(330, 275, 40, 40), stringFormat);
            g.DrawString(P4, font, Brushes.Black, new RectangleF(275, 330, 40, 40), stringFormat);
            g.DrawString(b5, font, Brushes.Black, new RectangleF(180, 350, 40, 40), stringFormat);
            g.DrawString(P5, font, Brushes.Black, new RectangleF(85, 330, 40, 40), stringFormat);
            g.DrawString(m6, font, Brushes.Black, new RectangleF(30, 275, 40, 40), stringFormat);
            g.DrawString(M6, font, Brushes.Black, new RectangleF(10, 180, 40, 40), stringFormat);
            g.DrawString(m7, font, Brushes.Black, new RectangleF(30, 85, 40, 40), stringFormat);
            g.DrawString(M7, font, Brushes.Black, new RectangleF(85, 30, 40, 40), stringFormat);

            //ChordPolygons list out of bound exception when adding second chord, resets ChordPolygons with every addition
            //Move ChordPolygons to Progression OBject
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
            bitmap = new Bitmap(1200 + (Progression.getSize() * 200), 525);
            Graphics g = Graphics.FromImage(bitmap);

            Font tabFont = new Font(FontFamily.GenericSerif, 50, FontStyle.Italic);
            Font font = new Font(FontFamily.GenericSansSerif, 34, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Pen blackPen = new Pen(Color.Black, 3);

            g.DrawString("T", tabFont, Brushes.Black, new RectangleF(75, 10, 50, 75));
            g.DrawString("A", tabFont, Brushes.Black, new RectangleF(75, 10, 50, 75));
            g.DrawString("B", tabFont, Brushes.Black, new RectangleF(75, 10, 50, 75));

            g.DrawLine(blackPen, 0, 75, 1200 + (Progression.getSize() * 200), 75);
            g.DrawLine(blackPen, 0, 150, 1200 + (Progression.getSize() * 200), 150);
            g.DrawLine(blackPen, 0, 225, 1200 + (Progression.getSize() * 200), 225);
            g.DrawLine(blackPen, 0, 300, 1200 + (Progression.getSize() * 200), 300);
            g.DrawLine(blackPen, 0, 375, 1200 + (Progression.getSize() * 200), 375);
            g.DrawLine(blackPen, 0, 450, 1200 + (Progression.getSize() * 200), 450);
        }

        private void drawSheetMusic ()
        {
            bitmap = new Bitmap(1200 + (Progression.getSize() * 200), 450);
            Graphics g = Graphics.FromImage(bitmap);

            Font keyFont = new Font(FontFamily.GenericSerif, 50, FontStyle.Italic);
            Font modeFont = new Font(FontFamily.GenericSerif, 28);
            Font font = new Font(FontFamily.GenericSerif, 34, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            Pen blackPen = new Pen(Color.Black, 3);

            string key = Progression.getKey().getName();
            string mode = Progression.getMode().getName();
            string chordOne = "vi6";
            string chordTwo = "ii";
            string chordThree = "V6";
            string chordFour = "I";

            bool hasFirstSharp = false;
            bool hasSecondSharp = false;
            bool hasThirdSharp = false;
            bool hasFourthSharp = false;
            bool hasFifthSharp = false;
            bool hasSixthSharp = false;
            bool hasSeventhSharp = false;

            bool hasFirstFlat = false;
            bool hasSecondFlat = false;
            bool hasThirdFlat = false;
            bool hasFourthFlat = false;
            bool hasFifthFlat = false;
            bool hasSixthFlat = false;
            bool hasSeventhFlat = false;

            bool firstTopBar = false;
            bool secondTopBar = false;
            bool thirdTopBar = false;
            bool fourthTopBar = false;

            bool firstBottomBar = false;
            bool secondBottomBar = false;
            bool thirdBottomBar = false;
            bool fourthBottomBar = false;

            Rectangle firstTrebleA5 = new Rectangle(400, 25, 65, 50);
            Rectangle secondTrebleA5 = new Rectangle(600, 25, 65, 50);
            Rectangle thirdTrebleA5 = new Rectangle(800, 25, 65, 50);
            Rectangle fourthTrebleA5 = new Rectangle(1000, 25, 65, 50);
            Rectangle firstTrebleG5 = new Rectangle(400, 50, 65, 50);
            Rectangle secondTrebleG5 = new Rectangle(600, 50, 65, 50);
            Rectangle thirdTrebleG5 = new Rectangle(800, 50, 65, 50);
            Rectangle fourthTrebleG5 = new Rectangle(1000, 50, 65, 50);
            Rectangle firstTrebleF5 = new Rectangle(400, 75, 65, 50);
            Rectangle secondTrebleF5 = new Rectangle(600, 75, 65, 50);
            Rectangle thirdTrebleF5 = new Rectangle(800, 75, 65, 50);
            Rectangle fourthTrebleF5 = new Rectangle(1000, 75, 65, 50);
            Rectangle firstTrebleE5 = new Rectangle(400, 100, 65, 50);
            Rectangle secondTrebleE5 = new Rectangle(600, 100, 65, 50);
            Rectangle thirdTrebleE5 = new Rectangle(800, 100, 65, 50);
            Rectangle fourthTrebleE5 = new Rectangle(1000, 100, 65, 50);
            Rectangle firstTrebleD5 = new Rectangle(400, 125, 65, 50);
            Rectangle secondTrebleD5 = new Rectangle(600, 125, 65, 50);
            Rectangle thirdTrebleD5 = new Rectangle(800, 125, 65, 50);
            Rectangle fourthTrebleD5 = new Rectangle(1000, 125, 65, 50);
            Rectangle firstTrebleC5 = new Rectangle(400, 150, 65, 50);
            Rectangle secondTrebleC5 = new Rectangle(600, 150, 65, 50);
            Rectangle thirdTrebleC5 = new Rectangle(800, 150, 65, 50);
            Rectangle fourthTrebleC5 = new Rectangle(1000, 150, 65, 50);
            Rectangle firstTrebleB4 = new Rectangle(400, 175, 65, 50);
            Rectangle secondTrebleB4 = new Rectangle(600, 175, 65, 50);
            Rectangle thirdTrebleB4 = new Rectangle(800, 175, 65, 50);
            Rectangle fourthTrebleB4 = new Rectangle(1000, 175, 65, 50);
            Rectangle firstTrebleA4 = new Rectangle(400, 200, 65, 50);
            Rectangle secondTrebleA4 = new Rectangle(600, 200, 65, 50);
            Rectangle thirdTrebleA4 = new Rectangle(800, 200, 65, 50);
            Rectangle fourthTrebleA4 = new Rectangle(1000, 200, 65, 50);
            Rectangle firstTrebleG4 = new Rectangle(400, 225, 65, 50);
            Rectangle secondTrebleG4 = new Rectangle(600, 225, 65, 50);
            Rectangle thirdTrebleG4 = new Rectangle(800, 225, 65, 50);
            Rectangle fourthTrebleG4 = new Rectangle(1000, 225, 65, 50);
            Rectangle firstTrebleF4 = new Rectangle(400, 250, 65, 50);
            Rectangle secondTrebleF4 = new Rectangle(600, 250, 65, 50);
            Rectangle thirdTrebleF4 = new Rectangle(800, 250, 65, 50);
            Rectangle fourthTrebleF4 = new Rectangle(1000, 250, 65, 50);
            Rectangle firstTrebleE4 = new Rectangle(400, 275, 65, 50);
            Rectangle secondTrebleE4 = new Rectangle(600, 275, 65, 50);
            Rectangle thirdTrebleE4 = new Rectangle(800, 275, 65, 50);
            Rectangle fourthTrebleE4 = new Rectangle(1000, 275, 65, 50);
            Rectangle firstTrebleD4 = new Rectangle(400, 300, 65, 50);
            Rectangle secondTrebleD4 = new Rectangle(600, 300, 65, 50);
            Rectangle thirdTrebleD4 = new Rectangle(800, 300, 65, 50);
            Rectangle fourthTrebleD4 = new Rectangle(1000, 300, 65, 50);
            Rectangle firstTrebleC4 = new Rectangle(400, 325, 65, 50);
            Rectangle secondTrebleC4 = new Rectangle(600, 325, 65, 50);
            Rectangle thirdTrebleC4 = new Rectangle(800, 325, 65, 50);
            Rectangle fourthTrebleC4 = new Rectangle(1000, 325, 65, 50);

            Rectangle firstBassC4 = new Rectangle(400, 25, 65, 50);
            Rectangle secondBassC4 = new Rectangle(600, 25, 65, 50);
            Rectangle thirdBassC4 = new Rectangle(800, 25, 65, 50);
            Rectangle fourthBassC4 = new Rectangle(1000, 25, 65, 50);
            Rectangle firstBassB3 = new Rectangle(400, 50, 65, 50);
            Rectangle secondBassB3 = new Rectangle(600, 50, 65, 50);
            Rectangle thirdBassB3 = new Rectangle(800, 50, 65, 50);
            Rectangle fourthBassB3 = new Rectangle(1000, 50, 65, 50);
            Rectangle firstBassA3 = new Rectangle(400, 75, 65, 50);
            Rectangle secondBassA3 = new Rectangle(600, 75, 65, 50);
            Rectangle thirdBassA3 = new Rectangle(800, 75, 65, 50);
            Rectangle fourthBassA3 = new Rectangle(1000, 75, 65, 50);
            Rectangle firstBassG3 = new Rectangle(400, 100, 65, 50);
            Rectangle secondBassG3 = new Rectangle(600, 100, 65, 50);
            Rectangle thirdBassG3 = new Rectangle(800, 100, 65, 50);
            Rectangle fourthBassG3 = new Rectangle(1000, 100, 65, 50);
            Rectangle firstBassF3 = new Rectangle(400, 125, 65, 50);
            Rectangle secondBassF3 = new Rectangle(600, 125, 65, 50);
            Rectangle thirdBassF3 = new Rectangle(800, 125, 65, 50);
            Rectangle fourthBassF3 = new Rectangle(1000, 125, 65, 50);
            Rectangle firstBassE3 = new Rectangle(400, 150, 65, 50);
            Rectangle secondBassE3 = new Rectangle(600, 150, 65, 50);
            Rectangle thirdBassE3 = new Rectangle(800, 150, 65, 50);
            Rectangle fourthBassE3 = new Rectangle(1000, 150, 65, 50);
            Rectangle firstBassD3 = new Rectangle(400, 175, 65, 50);
            Rectangle secondBassD3 = new Rectangle(600, 175, 65, 50);
            Rectangle thirdBassD3 = new Rectangle(800, 175, 65, 50);
            Rectangle fourthBassD3 = new Rectangle(1000, 175, 65, 50);
            Rectangle firstBassC3 = new Rectangle(400, 200, 65, 50);
            Rectangle secondBassC3 = new Rectangle(600, 200, 65, 50);
            Rectangle thirdBassC3 = new Rectangle(800, 200, 65, 50);
            Rectangle fourthBassC3 = new Rectangle(1000, 200, 65, 50);
            Rectangle firstBassB2 = new Rectangle(400, 225, 65, 50);
            Rectangle secondBassB2 = new Rectangle(600, 225, 65, 50);
            Rectangle thirdBassB2 = new Rectangle(800, 225, 65, 50);
            Rectangle fourthBassB2 = new Rectangle(1000, 225, 65, 50);
            Rectangle firstBassA2 = new Rectangle(400, 250, 65, 50);
            Rectangle secondBassA2 = new Rectangle(600, 250, 65, 50);
            Rectangle thirdBassA2 = new Rectangle(800, 250, 65, 50);
            Rectangle fourthBassA2 = new Rectangle(1000, 250, 65, 50);
            Rectangle firstBassG2 = new Rectangle(400, 275, 65, 50);
            Rectangle secondBassG2 = new Rectangle(600, 275, 65, 50);
            Rectangle thirdBassG2 = new Rectangle(800, 275, 65, 50);
            Rectangle fourthBassG2 = new Rectangle(1000, 275, 65, 50);
            Rectangle firstBassF2 = new Rectangle(400, 300, 65, 50);
            Rectangle secondBassF2 = new Rectangle(600, 300, 65, 50);
            Rectangle thirdBassF2 = new Rectangle(800, 300, 65, 50);
            Rectangle fourthBassF2 = new Rectangle(1000, 300, 65, 50);
            Rectangle firstBassE2 = new Rectangle(400, 325, 65, 50);
            Rectangle secondBassE2 = new Rectangle(600, 325, 65, 50);
            Rectangle thirdBassE2 = new Rectangle(800, 325, 65, 50);
            Rectangle fourthBassE2 = new Rectangle(1000, 325, 65, 50);

            Rectangle firstSharp = new Rectangle(135, 70, 25, 60);
            Rectangle secondSharp = new Rectangle(160, 120, 25, 60);
            Rectangle thirdSharp = new Rectangle(190, 95, 25, 60);
            Rectangle fourthSharp = new Rectangle(215, 145, 25, 60);
            Rectangle fifthSharp = new Rectangle(240, 195, 25, 60);
            Rectangle sixthSharp = new Rectangle(270, 170, 25, 60);
            Rectangle seventhSharp = new Rectangle(295, 220, 25, 60);

            Rectangle firstFlat = new Rectangle(140, 155, 25, 70);
            Rectangle secondFlat = new Rectangle(165, 80, 25, 70);
            Rectangle thirdFlat = new Rectangle(190, 180, 25, 70);
            Rectangle fourthFlat = new Rectangle(215, 105, 25, 70);
            Rectangle fifthFlat = new Rectangle(240, 205, 25, 70);
            Rectangle sixthFlat = new Rectangle(265, 130, 25, 70);
            Rectangle seventhFlat = new Rectangle(290, 230, 25, 70);

            //firstTopBar = true;
            //secondTopBar = true;
            //thirdTopBar = true;
            //fourthTopBar = true;

            //firstBottomBar = true;
            //secondBottomBar = true;
            //thirdBottomBar = true;
            //fourthBottomBar = true;

            //hasFirstSharp = true;
            //hasSecondSharp = true;
            //hasThirdSharp = true;
            //hasFourthSharp = true;
            //hasFifthSharp = true;
            //hasSixthSharp = true;
            //hasSeventhSharp = true;

            hasFirstFlat = true;
            hasSecondFlat = true;
            hasThirdFlat = true;
            hasFourthFlat = true;
            hasFifthFlat = true;
            hasSixthFlat = true;
            hasSeventhFlat = true;

            g.FillRectangle(Brushes.White, 0, 0, 1200, 450);

            g.DrawImage(Properties.Resources.TrebleClef, 5, 45, 140, 325);
            //g.DrawImage(Properties.Resources.BassClef, 5, 95, 150, 175);
            //g.DrawImage(Properties.Resources.AltoClef, 5, 100, 130, 200);

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

            g.DrawImage(Properties.Resources.WholeNote, firstBassC3);
            g.DrawImage(Properties.Resources.WholeNote, firstBassE3);
            g.DrawImage(Properties.Resources.WholeNote, firstBassA3);

            g.DrawImage(Properties.Resources.WholeNote, secondBassD3);
            g.DrawImage(Properties.Resources.WholeNote, secondBassF3);
            g.DrawImage(Properties.Resources.WholeNote, secondBassA3);

            g.DrawImage(Properties.Resources.WholeNote, thirdBassB2);
            g.DrawImage(Properties.Resources.WholeNote, thirdBassD3);
            g.DrawImage(Properties.Resources.WholeNote, thirdBassG3);
            //g.DrawImage(Properties.Resources.WholeNote, thirdBassE2);

            g.DrawImage(Properties.Resources.WholeNote, fourthBassC3);
            g.DrawImage(Properties.Resources.WholeNote, fourthBassE3);
            g.DrawImage(Properties.Resources.WholeNote, fourthBassG3);

            g.DrawLine(blackPen, 0, 100, 1200, 100);
            g.DrawLine(blackPen, 0, 150, 1200, 150);
            g.DrawLine(blackPen, 0, 200, 1200, 200);
            g.DrawLine(blackPen, 0, 250, 1200, 250);
            g.DrawLine(blackPen, 0, 300, 1200, 300);

            g.DrawLine(blackPen, 550, 100, 550, 300);
            g.DrawLine(blackPen, 750, 100, 750, 300);
            g.DrawLine(blackPen, 950, 100, 950, 300);
            g.DrawLine(blackPen, 1150, 100, 1150, 300);
            g.FillRectangle(Brushes.Black, new Rectangle(1175, 100, 25, 200));

            if (firstTopBar) { g.DrawLine(blackPen, 385, 50, 480, 50); }
            if (secondTopBar) { g.DrawLine(blackPen, 585, 50, 680, 50); }
            if (thirdTopBar) { g.DrawLine(blackPen, 785, 50, 880, 50); }
            if (fourthTopBar) { g.DrawLine(blackPen, 985, 50, 1080, 50); }

            if (firstBottomBar) { g.DrawLine(blackPen, 385, 350, 480, 350); }
            if (secondBottomBar) { g.DrawLine(blackPen, 585, 350, 680, 350); }
            if (thirdBottomBar) { g.DrawLine(blackPen, 785, 350, 880, 350); }
            if (fourthBottomBar) { g.DrawLine(blackPen, 985, 350, 1080, 350); }

            g.DrawString(key, keyFont, Brushes.Black, new RectangleF(50, 325, 200, 100), stringFormat);
            g.DrawString(mode, modeFont, Brushes.Black, new RectangleF(0, 400, 300, 50), stringFormat);

            g.DrawString(chordOne, font, Brushes.Black, new RectangleF(350, 380, 200, 70), stringFormat);
            g.DrawString(chordTwo, font, Brushes.Black, new RectangleF(550, 380, 200, 70), stringFormat);
            g.DrawString(chordThree, font, Brushes.Black, new RectangleF(750, 380, 200, 70), stringFormat);
            g.DrawString(chordFour, font, Brushes.Black, new RectangleF(950, 380, 200, 70), stringFormat);

            string path = Server.MapPath("~/Images/ProgressionSheetMusic.jpg");
            bitmap.Save(path, ImageFormat.Jpeg);
            ProgressionSheetMusic.ImageUrl = "~/Images/ProgressionSheetMusic.jpg";
            g.Dispose();
            bitmap.Dispose();
        }

        protected void KeyEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteController.checkNoteName(KeyEntryBox.Text))
            {
                Progression.changeKey(NoteFactory.getNoteByName(KeyEntryBox.Text));
                drawModalShape();
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

        protected void ModeEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (ModeController.checkModeName(ModeEntryBox.Text))
            {
                Progression.changeMode(ModeEntryBox.Text);
                drawModalShape();
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
                drawModalShape();
            }
        }


        protected void clearProgFunction(object sender, EventArgs e)
        {
            Progression.clearProgression();
        }

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

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RecommendedChordDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SwitchFirstChordDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SwitchSecondDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SwitchChordsButton_Click(object sender, EventArgs e)
        {

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

        protected void yesClearButton_Click(object sender, EventArgs e)
        {

        }

        protected void noClearButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateChordPointArray(Chord chord)
        {
            Point[] polygon = new Point[chord.getSize()];
            int tonicValue = Progression.getKey().getValue();
            int tonicValueOffset;
            for (int i = 0; i < chord.getSize(); i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    tonicValueOffset = tonicValue + j;
                    if (tonicValueOffset > 12) { tonicValueOffset = tonicValueOffset - 12; }
                    if (chord.getNoteAt(i).getValue() == tonicValueOffset) { polygon[i] = ModalShapePoints[j]; }
                }
            }
            Progression.addChordPolygon(polygon);
        }

    }
}
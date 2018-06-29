using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace ChordnomiconWebApplication.Images
{
    public class ChromaticGraphicFactory
    {
        private ChromaticGraphicFactory() { }

        static Bitmap bitmap;
        static int nextNote;

        public static void drawChromaticGeometry (string filePath, System.Web.UI.WebControls.Image image)
        {
            bitmap = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(bitmap);

            Font font = new Font(FontFamily.GenericSerif, 18, FontStyle.Italic);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Pen blackPen = new Pen(Color.Black, 3);
            Pen grayPen = new Pen(Color.Gray, 5);
            Pen goldPen = new Pen(Color.Gold, 3);
            Point pointOne = new Point(200, 50);
            Point pointTwo = new Point(275, 70);
            Point pointThree = new Point(330, 125);
            Point pointFour = new Point(350, 200);
            Point pointFive = new Point(330, 275);
            Point pointSix = new Point(275, 330);
            Point pointSeven = new Point(200, 350);
            Point pointEight = new Point(125, 330);
            Point pointNine = new Point(70, 275);
            Point pointTen = new Point(50, 200);
            Point pointEleven = new Point(70, 125);
            Point pointTwelve = new Point(125, 70);
            List<Point> points = new List<Point>();
            points.Add(pointOne);
            points.Add(pointTwo);
            points.Add(pointThree);
            points.Add(pointFour);
            points.Add(pointFive);
            points.Add(pointSix);
            points.Add(pointSeven);
            points.Add(pointEight);
            points.Add(pointNine);
            points.Add(pointTen);
            points.Add(pointEleven);
            points.Add(pointTwelve);

            string R = Progression.getKey().getName();
            nextNote = Progression.getKey().getValue() + 1;
            if (nextNote > 12) { nextNote = nextNote - 12; }
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
                    g.DrawLine(goldPen, points.ElementAt(firstPoint), points.ElementAt(secondPoint));
                }
                firstPoint = Progression.getMode().getIntervalValue(i);
            }
            g.DrawLine(goldPen, points.ElementAt(firstPoint), points.ElementAt(0));

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

            //string path = Server.MapPath(filePath);
            bitmap.Save(filePath, ImageFormat.Jpeg);
            image.ImageUrl = filePath;
            g.Dispose();
            bitmap.Dispose();
        }
    }
}
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
    public partial class About : System.Web.UI.Page
    {
        Bitmap bitmap;


        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                drawModalShape();
            }
            
        }
        
        private void drawModalShape()
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

            string R = "D";
            string m2 = "Eb";
            string M2 = "E";
            string m3 = "F";
            string M3 = "F#";
            string P4 = "G";
            string b5 = "Ab";
            string P5 = "A";
            string m6 = "Bb";
            string M6 = "B";
            string m7 = "C";
            string M7 = "C#";

            g.Clear(Color.White);
            g.DrawEllipse(grayPen, 50, 50, 300, 300);
            g.DrawEllipse(blackPen, 50, 50, 300, 300);

            g.DrawLine(goldPen, pointOne, pointThree);
            g.DrawLine(goldPen, pointThree, pointFour);
            g.DrawLine(goldPen, pointFour, pointSix);
            g.DrawLine(goldPen, pointSix, pointEight);
            g.DrawLine(goldPen, pointEight, pointTen);
            g.DrawLine(goldPen, pointTen, pointEleven);
            g.DrawLine(goldPen, pointEleven, pointOne);

            g.DrawLine(goldPen, pointOne, pointSix);
            g.DrawLine(goldPen, pointOne, pointEight);
            g.DrawLine(goldPen, pointThree, pointEight);
            g.DrawLine(goldPen, pointThree, pointTen);
            g.DrawLine(goldPen, pointFour, pointEleven);
            g.DrawLine(goldPen, pointSix, pointEleven);
            g.DrawLine(goldPen, pointTen, pointThree);
            g.DrawLine(goldPen, pointFour, pointTen);

            g.DrawLine(goldPen, pointOne, pointFour);
            g.DrawLine(goldPen, pointOne, pointTen);
            g.DrawLine(goldPen, pointThree, pointEight);
            g.DrawLine(goldPen, pointThree, pointSix);
            g.DrawLine(goldPen, pointSix, pointTen);
            g.DrawLine(goldPen, pointEight, pointEleven);
            g.DrawLine(goldPen, pointEight, pointFour);
            g.DrawLine(goldPen, pointEleven, pointThree);

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

            string path = Server.MapPath("~/Pages/modalShape.jpg");
            bitmap.Save(path, ImageFormat.Jpeg);
            Image1.ImageUrl = "~/Pages/modalShape.jpg";
            g.Dispose();
            bitmap.Dispose();
        }
    }
}
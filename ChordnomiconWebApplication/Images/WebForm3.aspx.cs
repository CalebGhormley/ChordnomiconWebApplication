using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChordnomiconWebApplication.Images
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Bitmap bitm;

        public WebForm3()
        {
            bitm = new Bitmap(600, 400);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                drawRectangle();
            }
        }

        private void drawRectangle()
        {
            Graphics graphics = Graphics.FromImage(bitm);
            graphics.Clear(Color.Black);
            Pen pen = new Pen(Color.White, 2);
            graphics.DrawRectangle(pen, 50, 50, 250, 200);
            string path = Server.MapPath("~/Images/rect.jpg");
            bitm.Save(path, ImageFormat.Jpeg);
            Image1.ImageUrl = "~/Images/rect.jpg";
            graphics.Dispose();
            bitm.Dispose();
        }
    }
}
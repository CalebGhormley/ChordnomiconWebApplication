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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap curBitmap = new Bitmap("400px_with_300px_Circle.jpg");
            Graphics g = Graphics.FromImage(curBitmap);
            curBitmap.Save(this.Response.OutputStream, ImageFormat.Jpeg);
            g.Dispose();
        }
    }
}
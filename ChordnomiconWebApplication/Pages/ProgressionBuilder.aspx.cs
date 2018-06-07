using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChordnomiconWebApplication.Pages
{
    public partial class ProgressionBuilder : System.Web.UI.Page
    {
        bool keyIsSet = false;
        bool modeIsSet = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (NoteController.checkNoteName(TextBox1.Text))
            {
                Progression.changeKey(NoteFactory.getNoteByName(TextBox1.Text));
                keyIsSet = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (keyIsSet)
            {
                Label1.Text = "The current key is: " + Progression.getKey().getName();
            }
            else { Label1.Text = "Please select a valid key name"; }
        }
    }
}
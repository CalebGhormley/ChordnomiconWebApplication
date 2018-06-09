using ChordnomiconWebApplication.Musical_Objects;
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

        protected void KeyEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteController.checkNoteName(KeyEntryBox.Text))
            {
                Progression.changeKey(NoteFactory.getNoteByName(KeyEntryBox.Text));
                keyIsSet = true;
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
                modeIsSet = true;
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
    }
}
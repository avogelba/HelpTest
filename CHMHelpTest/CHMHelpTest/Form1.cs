using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHMHelpTest
{
    public partial class Form1 : Form
    {
        private const string myHelpfile = "Test Help.chm";

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(indexOfHelp, "Jump to the Index of my Help file");
            toolTip1.SetToolTip(showContents, "Jump to Contents");
            toolTip1.SetToolTip(showMiscellaneous, "I want to know allot about Miscellaneous stuff");

        }

        private void indexOfHelp_Click(object sender, System.EventArgs e)
        {
            Help.ShowHelpIndex(this, myHelpfile);
        }
    
        private void showMiscellaneous_Click(object sender, System.EventArgs e)
        {
            Help.ShowHelp(this, myHelpfile, "/hlp/Miscellaneous.htm");
        }

        private void showContents_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, myHelpfile, "/hlp/Contents.htm");
        }

        private void showPopUp_Click(object sender, EventArgs e)
        {
            Point showPopUpLoc = showPopUp.FindForm().PointToClient(
                            showPopUp.Parent.PointToScreen(showPopUp.Location)
                            );
                        

            Help.ShowPopup(this, "My PopUp", showPopUp.PointToScreen(Point.Empty));


        }
    }
}

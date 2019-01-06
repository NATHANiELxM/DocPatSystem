/*
 * This is the Doctor Home page. From the login screen, to here. 
 * Use the buttons on the left of the page to go to different services. 
 * 
 *  A logout button will be at the top of the page and will be able to take you back to login without exiting the system.
 *  
 *  Currently the tabs are a size of 900, by 433.  The Sizes, Fonts, Colors can all be changed, it should just be consistant. 
 *                                                                      ^ I was wanting to use dark colors and white text, but I did not end up doing that. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocPatSystem
{
    public partial class docHome : Form
    {
        public docHome()
        {
            InitializeComponent();
        }


        //click this to exit the system (need logout still)
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //These button clicks will display respective User Controls and change the header with info 
        private void appButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text="Appointments";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.appointments();
            displayPanel.Controls.Add(myControl);

        }

        private void newScriptButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "New Perscriptions";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.newScript();
            displayPanel.Controls.Add(myControl);
        }

        private void refillReqButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Refill Requests";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.refillReq();
            displayPanel.Controls.Add(myControl);
        }

        private void callReqButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Calls";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.callReq();
            displayPanel.Controls.Add(myControl);
        }

        private void recordsButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Medical Recods";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.patientRecords();
            displayPanel.Controls.Add(myControl);
        }

       
    }
}

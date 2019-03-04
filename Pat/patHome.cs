/*
 * This is the Patient Home page, you must login as a patient to get to this form.
 * Use the buttons on the left of the page to go to different services. 
 * 
 *  A logout button will be at the top of the page and will be able to take you back to login without exiting the system.
 * 
 * 
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
    public partial class patHome : Form
    {
        public patHome()
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
            currentTabLabel.Text = "Make A New Appointment";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.makeAppPat();
            displayPanel.Controls.Add(myControl);
        }

        private void refillMedButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Refill Medication Options";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.refillMeds();
            displayPanel.Controls.Add(myControl);
        }

        private void callADocButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Call A Doctor";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.makeCall();
            displayPanel.Controls.Add(myControl);
        }

        private void recordsButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "My Medical Records";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.myRecords();
            displayPanel.Controls.Add(myControl);
        }

        
    }
}

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
    public partial class pharmHome : Form
    {
        public pharmHome()
        {
            InitializeComponent();
        }

        //click this to exit the system (need logout still)
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //These button clicks will display respective User Controls and change the header with info 
        private void refillButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Incoming Refill Requests";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.Pharm.refillReqs();
            displayPanel.Controls.Add(myControl);
        }

        private void newButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "Incoming Prescription Requests";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.Pharm.incomingScrips();
            displayPanel.Controls.Add(myControl);
        }

        private void activeButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "All Active Prescriptions";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.Pharm.activePrescriptions();
            displayPanel.Controls.Add(myControl);
        }

        private void caseButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "All Active Cases";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.Pharm.activeCases();
            displayPanel.Controls.Add(myControl);
        }

        private void medRecodsButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "All Records";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.Pharm.allRecords();
            displayPanel.Controls.Add(myControl);
        }

        // this doesn't work, it is for a new case from acvitve cases
        private void newCaseButt_Click(object sender, EventArgs e)
        {
            //Update header
            currentTabLabel.Text = "New Case";
            currentTabLabel.Refresh();
            //Make sure the panel is clear
            displayPanel.Controls.Clear();
            //intitalize and add the control to the display panel
            var myControl = new DocPatSystem.Pharm.makeCasePharm();
            displayPanel.Controls.Add(myControl);
        }

        private void systemLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

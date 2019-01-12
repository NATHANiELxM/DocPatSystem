/*
 * This is the make appointments (patient) user control.
 * Just click on the make an appointment button on the patient homepage to get here.
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocPatSystem
{
    public partial class makeAppPat : UserControl
    {
        public makeAppPat()
        {
            InitializeComponent();
        }

        //~TO DO:Radio Buttons will gray-out the other text boxes
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //This button sends the data to the database, and send the request to the doctor system.
        private void reqAppButt_Click(object sender, EventArgs e)
        {

        }

        //Textboxes
        private void famDocTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void otherTB_TextChanged(object sender, EventArgs e)
        {

        }
        //Time dropdown for choice of hourly times
        private void timeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Calender for day/month/year picking
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void reasonTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

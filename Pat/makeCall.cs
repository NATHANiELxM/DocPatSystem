/*
 * This is the make calls user control for the patient.
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
    public partial class makeCall : UserControl
    {
        public makeCall()
        {
            InitializeComponent();
        }

        //This button sends a call request to the doctor selected from the combo box that will get doctors from the database
        private void callButt_Click(object sender, EventArgs e)
        {
            // sends the name and number to the active call tab to the right. (assuming they answer)
        }

        //This button takes the actice call and ends it, logs it into the datbase as an ended call. (ended being the status)
        private void endCallButt_Click(object sender, EventArgs e)
        {

        }



        //These next two buttons are optional. just for show for now.
        private void holdButt_Click(object sender, EventArgs e)
        {

        }

        private void muteButt_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void urgentCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

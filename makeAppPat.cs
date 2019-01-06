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
    }
}

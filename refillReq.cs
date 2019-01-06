/*
 * This is the refill request User Control tab
 * You will get here by pressing the Refill Request Button on the Doctor home page
 * 
 * The DataGridView is for the Refill Requests table which will get info from the database (patient name, medication, quanitiy, reason?)
 *                                              ^ the table should be refills with a status of "requested"
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
    public partial class refillReq : UserControl
    {
        public refillReq()
        {
            InitializeComponent();
        }

        //Both buttons will remove a selected row from the refill request table. If approved it is sent to the pharmacy system.
        private void acceptButt_Click(object sender, EventArgs e)
        {
            //This button accepts the refill request, status is set to accepted, sent to pharmacy system to be processed.
        }

        private void denyButt_Click(object sender, EventArgs e)
        {
            //This button denies the refill. status is set to denied, the patient is notified. 
        }
    }
}

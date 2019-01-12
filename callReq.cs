/*
 * This is the call request User control tab. From DR home page button call requests. 
 * I added the active call side, LET ME KNOW IF YOU GUYS THINK IT SHOULD BE THERE.
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
    public partial class callReq : UserControl
    {
        public callReq()
        {
            InitializeComponent();
        }

        //This button takes the selected patient from the call request table and sets the status to active call (if they answer.)
        private void callButt_Click(object sender, EventArgs e)
        {
            // sends the name and number to the active call tab to the right. 
        }

        //This button takes the actice call and ends it, logs it into the datbase as an ended call. (ended being the status)
        private void endCallButt_Click(object sender, EventArgs e)
        {

        }

        //These next two buttons are optional. just for show for now.
        private void muteButt_Click(object sender, EventArgs e)
        {

        }

        private void holdButt_Click(object sender, EventArgs e)
        {

        }

        private void callReqPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //This is the table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

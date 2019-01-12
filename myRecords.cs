/*
 * This is the my records user control. 
 * I assumed we do not allow just-anyone to change medical records, so only doctors will be able to, unless you all think otherwise.
 * All of the text boxes will be filled with data from the database.
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
    public partial class myRecords : UserControl
    {
        public myRecords()
        {
            InitializeComponent();
        }

        //This button opens a new form or control tab that will be able to see who has access and change access to their records
        //It will be very similar to the other earlier version 
        private void accessButt_Click(object sender, EventArgs e)
        {

        }

        //Textboxes
        private void dobTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ssnTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void heightTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void famDocTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void allergiesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void proceduresTB_TextChanged(object sender, EventArgs e)
        {

        }
        // RX History table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

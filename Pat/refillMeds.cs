/*
 * This is the refill medication user control
 * 
 * The DataGridView will get current medication from the database for this user
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
    public partial class refillMeds : UserControl
    {
        public refillMeds()
        {
            InitializeComponent();
        }

        //This button takes a selected medication and asks the doctor they got it from for a refill
        private void reqRefillButt_Click(object sender, EventArgs e)
        {

        }

        //current medications, with no remaining refills
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

/* 
 * This is the new prescriptions User control.
 * This should be displyed when the "New Prescriptions" button is clicked.
 * 
 * I used a DataGridView again, but this time it maight not be needed as it is not in the database. 
 *                            that side is temp storage until it the send request button us pressed.
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
    public partial class newScript : UserControl
    {
        public newScript()
        {
            InitializeComponent();
        }

        //add to perscription button
        private void add2ScriptButt_Click(object sender, EventArgs e)
        {
            //This makes sure they cannont change pharmacy or patient mid-writing-prescriptions
            patientID.ReadOnly = true;
            pharmacyID.ReadOnly = true;
            pharmacyID.BackColor = Color.Gray;
            patientID.BackColor = Color.Gray;

            //Still to do-
            //This button will add the info to the table to the right for review.
        }

        //send prescription request
        private void sendScriptReq_Click(object sender, EventArgs e)
        {
            //This button gathers info from the table to be sent to the database as a prescription request
            //once sent it should clear the screen of old info.
        }



        //NO LABEL CLICKS ARE USED, DID NOT KNOW HOW TO GET RID OF WITHOUT GIVING ERRORS
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }


        //Textboxes
        private void patientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pharmacyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void prescriptionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void refillAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        //current prescriptions table for current patient
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

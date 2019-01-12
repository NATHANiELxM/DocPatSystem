/*
 * This is tha patient records user control. By pressing the "patient Medical Records" you get to this tab. 
 * 
 * ~~~~~NOT FINISHED ~~ The  "viewButt", "recordAccessButt" and "addNewPatientButt" Buttons need to open a 
 *                                new form or new user control which will look similar to the last program to get tasks done.
 * ~~~ I HAVE TOOK SOME SHORTCUTS ON THIS ONE JUST SO I COULD SHOW THE REST TO YOU GUYS
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
    public partial class patientRecords : UserControl
    {
        public patientRecords()
        {
            InitializeComponent();
        }


        //This will take the selected record from the table and in a new form or tab, display that patients information. 
        private void viewButt_Click(object sender, EventArgs e)
        {

        }

        //This button view the access of a selected persons recods and/or goes to where you can allow access to other doctors 
        private void recordAccessButt_Click(object sender, EventArgs e)
        {

        }

        //This is the search botton. I wanted it to be a magnifiying glass, but this will do.
        private void searchButt_Click(object sender, EventArgs e)
        {
            //once clicked it will search for that name in the patirent (first/last) name catigories in the database
            //it should also change "searchResultsLabel" so that is does not say all patient records. 
            // to do also ~~ add a clear search button.
        }

        //This button will let a doctor add a new patient. It will open a new tab or from and we will go from there. 
        private void addNewPatientButt_Click(object sender, EventArgs e)
        {

        }



        //NOT USED ; IGNORE
        private void label1_Click(object sender, EventArgs e)
        {
        }

        //search Textbox
        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

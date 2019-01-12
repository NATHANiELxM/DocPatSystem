/*
 *  This is the Appointments User Control. 
 *  It will be displayed when the Appointments button is clicked on the Doctor Home page.
 *  
 *  ~~~~TO RYAN AND CHRIS: DO WE NEED A "Make New Appointments" Button?
 *  ~~ Also I used DataGridView for the tables, and I used unbound items for looks, 
 *  but I think to connect to the database it hase to be bound (to the database). RIght click and go to add/edit columns to see what I mean.
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
    public partial class appointments : UserControl
    {
        public appointments()
        {
            InitializeComponent();
        }



        //This is the button in confirmed appointments panel
        private void cancelButt_Click(object sender, EventArgs e)
        {
            //This cancels a selected confirmed appointment. isAppointmentApproved? will change from approved to canceled. and will be removed from table.
        }



        //These buttons are in the awaiting approval panel
        private void denyButt_Click(object sender, EventArgs e)
        {
            //this denys a selected awaiting appointment. so it turns isAppointmentApproved? to denied and deletes it from this table
        }

        private void approveButt_Click(object sender, EventArgs e)
        {
            //this approves a selected awaiting appointment.
            // so it turns isAppointmentApproved? to approved (witch should move it to the left table in real time)
        }

        private void makeButt_Click(object sender, EventArgs e)
        {
            //DO WE NEED THIS BUTTON?!? I kinda thought we do, but idk.
            //I saw ryan's make appointment button and was not for sure if it was to make a new on or confirm an awaiting one. 

            //This will make a new auto-approved appointment.
        }


        
        private void currentAppsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void awaitingAppsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DocPatSystem
{
    public partial class appointments : UserControl
    {
        public appointments()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        string appID;
        string date;
        string time;
        string patID;
        string reason;

        //This is the button in confirmed appointments panel
        private void cancelButt_Click(object sender, EventArgs e)
        {
            //This cancels a selected confirmed appointment. isAppointmentApproved? will change from approved to canceled. and will be removed from table.

            //currentAppsTable.SelectedRows;
            //currentAppsTable.DataSource = bindingSource1;

            if (this.currentAppsTable.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to cancel the selected row?", "Confirm Cancel", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    try
                    {

                        string val = currentAppsTable.SelectedCells[0].Value.ToString();
                        currentAppsTable.DataSource = bindingSource1;   // CAN for CANCELED
                        GetData("update crn_appointment set status = 'CAN' where ID = '" + val + "'");

                        // I want to make the user selected rows deleted from the datagridview and from the database
                        bindingSource1.RemoveAt(this.currentAppsTable.SelectedRows[0].Index);
                        //currentAppsTable.Refresh();
                    }
                    catch (ArgumentOutOfRangeException outOfRange)
                    {

                        Console.WriteLine("Error: {0}", outOfRange.Message);
                        GetData("select ID, date, time, patient_ID, reason from crn_appointment where status = 'CON' order by date , time ");

                    }
                }
                if (confirm == DialogResult.Cancel)
                {
                    currentAppsTable.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Please select a row to cancel", "Cancel");
            }
        }



        //These buttons are in the awaiting approval panel
        private void denyButt_Click(object sender, EventArgs e)
        {
            //this denys a selected awaiting appointment. so it turns isAppointmentApproved? to denied and deletes it from this table
            if (this.awaitingAppsTable.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to deny the selected row?", "Confirm Deny", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    try
                    {

                        string val = awaitingAppsTable.SelectedCells[0].Value.ToString();
                        awaitingAppsTable.DataSource = bindingSource1;   // DEN for DENIED
                        GetData("update crn_appointment set status = 'DEN' where ID = '" + val + "'");

                        // I want to make the user selected rows deleted from the datagridview and from the database
                        bindingSource1.RemoveAt(this.awaitingAppsTable.SelectedRows[0].Index);
                        //currentAppsTable.Refresh();
                    }
                    catch (ArgumentOutOfRangeException outOfRange)
                    {

                        Console.WriteLine("Error: {0}", outOfRange.Message);
                        GetData("select ID, date, time, patient_ID, reason from crn_appointment where status = 'CON' order by date , time ");
                        GetData2("select ID, date, time, patient_ID, reason from crn_appointment where status = 'REQ' order by date , time ");

                    }
                }
                if (confirm == DialogResult.Cancel)
                {
                    awaitingAppsTable.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Please select a row to deny", "Deny");
            }
        
    }

        private void approveButt_Click(object sender, EventArgs e)
        {
            //this approves a selected awaiting appointment.
            if (this.awaitingAppsTable.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to approve the selected row?", "Confirm Approve", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    try
                    {

                        string val = awaitingAppsTable.SelectedCells[0].Value.ToString();
                        awaitingAppsTable.DataSource = bindingSource1;   // CON for CONFIRMED
                        GetData("update crn_appointment set status = 'CON' where ID = '" + val + "'");

                        // I want to make the user selected rows deleted from the datagridview and from the database
                        bindingSource1.RemoveAt(this.awaitingAppsTable.SelectedRows[0].Index);
                        
                    }
                    catch (ArgumentOutOfRangeException outOfRange)
                    {

                        Console.WriteLine("Error: {0}", outOfRange.Message);
                        //refresh the datagridView
                        GetData("select ID, date, time, patient_ID, reason from crn_appointment where status = 'CON' order by date , time ");
                        GetData2("select ID, date, time, patient_ID, reason from crn_appointment where status = 'REQ' order by date , time ");

                    }
                }
                if (confirm == DialogResult.Cancel)
                {
                    awaitingAppsTable.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Please select a row to approve", "Approve");
            }
        
    }

        private void makeButt_Click(object sender, EventArgs e)
        {
            Doc.setupApp newSetupAppPage = new Doc.setupApp();
            newSetupAppPage.FormClosed += new FormClosedEventHandler(newSetupAppPageClosed);
            newSetupAppPage.Show();
            this.Hide();


        }
        void newSetupAppPageClosed(object sender, FormClosedEventArgs e)
        {
            currentAppsTable.Refresh();
            this.Show();
            GetData("select ID, date, time, patient_ID, reason from crn_appointment where status = 'CON' order by date , time ");
            GetData2("select ID, date, time, patient_ID, reason from crn_appointment where status = 'REQ' order by date , time ");
        }


        private void currentAppsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   // does this really do anything?
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.currentAppsTable.Rows[e.RowIndex];
                string appID = row.Cells["ID"].Value.ToString();
                string date = row.Cells["date"].Value.ToString();
                string time = row.Cells["time"].Value.ToString();
                string patID = row.Cells["patient_ID"].Value.ToString();
                string reason = row.Cells["reason"].Value.ToString();
            }
        }

        private void awaitingAppsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void appointments_Load(object sender, EventArgs e)
        {
            
            //add using MySql.Data.MySqlClient; & using System.Data.SqlClient; to top 
            // add private BindingSource bindingSource1 = new BindingSource(); as variable
            currentAppsTable.DataSource = bindingSource1;
            GetData("select ID, date, time, patient_ID, reason from crn_appointment where status = 'CON' order by date , time ");
            awaitingAppsTable.DataSource = bindingSource2;
            GetData2("select ID, date, time, patient_ID, reason from crn_appointment where status = 'REQ' order by date , time ");
        }

        //get the data from the DB
        private void GetData(string selectCommand)
        {
            try
            {

                String connectionString = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";
                MySqlConnection conDB = new MySqlConnection(connectionString);
                MySqlCommand cmdDB = new MySqlCommand(selectCommand, conDB);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDB;
                    DataTable dbDataSet = new DataTable();
                    sda.Fill(dbDataSet);

                    bindingSource1.DataSource = dbDataSet;
                    currentAppsTable.DataSource = bindingSource1;
                    sda.Update(dbDataSet);
                    // Resize the DataGridView columns to fit the newly loaded content.
                    currentAppsTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

        }

       
        private void GetData2(string selectCommand)
        {
            try
            {

                String connectionString = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";
                MySqlConnection conDB = new MySqlConnection(connectionString);
                MySqlCommand cmdDB = new MySqlCommand(selectCommand, conDB);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDB;
                    DataTable dbDataSet = new DataTable();
                    sda.Fill(dbDataSet);

                    bindingSource2.DataSource = dbDataSet;
                    awaitingAppsTable.DataSource = bindingSource2;
                    sda.Update(dbDataSet);
                    // Resize the DataGridView columns to fit the newly loaded content.
                    awaitingAppsTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

        }
    }
}

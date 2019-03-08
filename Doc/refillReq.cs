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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DocPatSystem
{
    public partial class refillReq : UserControl
    {
        private BindingSource bindingSource1 = new BindingSource();

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

        // table of patients requesting refills on specific medication
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refillReq_Load(object sender, EventArgs e)
        {
            //add using MySql.Data.MySqlClient; & using System.Data.SqlClient; to top 
            // add private BindingSource bindingSource1 = new BindingSource(); as variable
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from crn_refill_request");
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
                    dataGridView1.DataSource = bindingSource1;
                    sda.Update(dbDataSet);
                    // Resize the DataGridView columns to fit the newly loaded content.
                    //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
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

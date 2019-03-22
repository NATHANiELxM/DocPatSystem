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
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocPatSystem
{
    public partial class patientRecords : UserControl
    {
        private DataGridView dataGridView = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public patientRecords()
        {
            InitializeComponent();
        }


        //This will take the selected record from the table and in a new form or tab, display that patients information. 
        private void viewButt_Click(object sender, EventArgs e)
        {
            Doc.viewRecord newViewRecordPage = new Doc.viewRecord();
            newViewRecordPage.FormClosed += new FormClosedEventHandler(newViewRecordPageClosed);
            newViewRecordPage.Show();
            this.Hide();
        }
        void newViewRecordPageClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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
            Doc.addNewRecord newAddNewRecordPage = new Doc.addNewRecord();
            newAddNewRecordPage.FormClosed += new FormClosedEventHandler(newAddNewRecordPageClosed);
            newAddNewRecordPage.Show();
            this.Hide();
        }
        void newAddNewRecordPageClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.Refresh();
            this.Show();
        }


        //NOT USED ; IGNORE
        private void label1_Click(object sender, EventArgs e)
        {
        }

        //search Textbox
        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientRecords_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from crn_medical_record");
        }

        //get the data from the DB
        private void GetData(string selectCommand)
        {
            try
            {
                
                String connectionString ="server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";
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
                catch(Exception ex)
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

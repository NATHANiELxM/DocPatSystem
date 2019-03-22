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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DocPatSystem
{
    public partial class refillMeds : UserControl
    {
        private BindingSource bindingSource1 = new BindingSource();
       // private SqlDataAdapter dataAdapter = new SqlDataAdapter();

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

        private void refillMeds_Load(object sender, EventArgs e)
        {
            //add using MySql.Data.MySqlClient; & using System.Data.SqlClient; to top 
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from crn_medicine");
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
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

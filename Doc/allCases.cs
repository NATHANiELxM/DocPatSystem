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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DocPatSystem
{
    public partial class callReq : UserControl
    {
        
        private BindingSource bindingSource1 = new BindingSource();
        public callReq()
        {
            InitializeComponent();
        }

        //NEW CASE BUTTON
        private void callButt_Click(object sender, EventArgs e)
        {
            Doc.makeCaseForm newMakeCaseForm = new Doc.makeCaseForm();
            newMakeCaseForm.FormClosed += new FormClosedEventHandler(newMakeCaseFormClosed);
            newMakeCaseForm.Show();
            this.Hide();

        }
        void newMakeCaseFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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
            //add using MySql.Data.MySqlClient; & using System.Data.SqlClient; to top 
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from crn_notice");
        }

        //This is the table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doc.viewCaseForm newViewCaseForm = new Doc.viewCaseForm();
            newViewCaseForm.FormClosed += new FormClosedEventHandler(newViewCaseFormClosed);
            newViewCaseForm.Show();
            this.Hide();
        }
        void newViewCaseFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void allCases_Load(object sender, EventArgs e)
        {
            
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

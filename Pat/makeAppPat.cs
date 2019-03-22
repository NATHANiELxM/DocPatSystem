/*
 * This is the make appointments (patient) user control.
 * Just click on the make an appointment button on the patient homepage to get here.
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
    public partial class makeAppPat : UserControl
    {
        public makeAppPat()
        {
            InitializeComponent();
        }

        //~TO DO:Radio Buttons will gray-out the other text boxes
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //This button sends the data to the database, and send the request to the doctor system.
        private void reqAppButt_Click(object sender, EventArgs e)
        {

            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {
                string enteredDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                string enteredTime = timeDropDown.SelectedItem.ToString();

                string enteredReason = reasonTB.Text;

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();


                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ later get userid(PAT) & Doc from textbox and put here \/
                string sql = "INSERT INTO crn_appointment (date, time, reason, doc_ID, patient_ID, status) VALUES (@udate, @utime, @ureason, 4, 2,'REQ')";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@udate", enteredDate);
                cmd.Parameters.AddWithValue("@utime", enteredTime);
                cmd.Parameters.AddWithValue("@ureason", enteredReason);


                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.ToString());

            }

            conn.Close();

            Console.WriteLine("Done.");

            System.Windows.Forms.MessageBox.Show("You have requested an appointment.");
        }

    

        void newSetupAppPageClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //Textboxes
        private void famDocTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void otherTB_TextChanged(object sender, EventArgs e)
        {

        }
        //Time dropdown for choice of hourly times
        private void timeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Calender for day/month/year picking
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void reasonTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

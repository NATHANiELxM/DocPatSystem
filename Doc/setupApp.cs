using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocPatSystem.Doc
{
    public partial class setupApp : Form
    {
        public setupApp()
        {
            InitializeComponent();
        }

        //This will make a new auto-approved appointment.
        private void makeAppButt_Click(object sender, EventArgs e)
        {
            

            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {
                string enteredDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                string enteredTime = timeDropDown.SelectedItem.ToString();

                string enteredReason = reasonTB.Text;
                int enteredPatID = Int32.Parse(patIDTB.Text);

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();


                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ later get user id(Doc) and put here \/
                string sql = "INSERT INTO crn_appointment (date, time, reason, doc_ID, patient_ID, status) VALUES (@udate, @utime, @ureason, 4, @upatID,'CON')";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@udate", enteredDate);
                cmd.Parameters.AddWithValue("@utime", enteredTime);
                cmd.Parameters.AddWithValue("@ureason", enteredReason);
                cmd.Parameters.AddWithValue("@upatID", enteredPatID);
                

                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.ToString());

            }

            conn.Close();

            Console.WriteLine("Done.");

            this.Close();
        }

    }

}

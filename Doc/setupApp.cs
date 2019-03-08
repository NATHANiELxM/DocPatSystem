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

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();

                string sql = "INSERT INTO crn_appointment (date, time, reason, gender, doc_ID, patient_ID) VALUES (@udate, @utime, @ureason, 4, @upatID,'APP')";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

               // cmd.Parameters.AddWithValue("@udate", date);
              //  cmd.Parameters.AddWithValue("@utime", time);
              //  cmd.Parameters.AddWithValue("@ureason", reason);
             //   cmd.Parameters.AddWithValue("@upatID", patID);
                

                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.ToString());

            }

            conn.Close();

            Console.WriteLine("Done.");
        
    }
    }

}

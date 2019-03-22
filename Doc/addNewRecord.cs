using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocPatSystem.Doc
{
    public partial class addNewRecord : Form
    {
        public addNewRecord()
        {
            InitializeComponent();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            int enteredID = Int32.Parse(nameTB.Text);
            int enteredheight = Int32.Parse(heightTB.Text);
            int enteredweight = Int32.Parse(weightTB.Text);

            string enteredGender = genderTB.Text;
            string enteredAllergies = allergiesTB.Text;
            string enteredSurgeries = proceduresTB.Text;

            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();

                string sql = "INSERT INTO crn_medical_record (patient_ID, height, weight, gender, allergies, surgeries) VALUES (@uid, @uheight, @uweight, @ugender, @uallergies, @usurgeries)";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@uid", enteredID);

                cmd.Parameters.AddWithValue("@uheight", enteredheight);
                cmd.Parameters.AddWithValue("@uweight", enteredweight);
                cmd.Parameters.AddWithValue("@ugender", enteredGender);
                cmd.Parameters.AddWithValue("@uallergies", enteredAllergies);
                cmd.Parameters.AddWithValue("@usurgeries", enteredSurgeries);

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

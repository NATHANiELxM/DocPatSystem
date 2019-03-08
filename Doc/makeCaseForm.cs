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
    public partial class makeCaseForm : Form
    {
        public makeCaseForm()
        {
            InitializeComponent();
        }

        private void sendButt_Click(object sender, EventArgs e)
        {
            string notType = noticeTypeTB.Text;
            string status = "Sent";
            string notMessage = noticeTB.Text;
            int docFrom = Int32.Parse(fromTB.Text);
            int personTo = Int32.Parse(toTB.Text);


            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();
                
                string sql = "INSERT INTO crn_notice (type, status, message, doc_sender, doc_receiver) VALUES (@utype, @ustatus, @umessage, @ufrom, @uto)";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@utype", notType);
                cmd.Parameters.AddWithValue("@ustatus", status );
                cmd.Parameters.AddWithValue("@umessage", notMessage);
                cmd.Parameters.AddWithValue("@ufrom", docFrom);
                cmd.Parameters.AddWithValue("@uto", personTo);

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

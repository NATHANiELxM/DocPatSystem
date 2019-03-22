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

namespace DocPatSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        // login button, I was going to rename it but it was messing up the design side
        // For Testing "Dr" goes to doctor page and "Pat" goes to patient
        private void Button1_Click(object sender, EventArgs e)
        {
            string localDOCUsername = usernameTB1.Text;
            string localDOCPassword = passwordTB2.Text;

            string localPharmUsername = usernameTB1.Text;
            string localPharmPassword = passwordTB2.Text;

            string localPatUsername = usernameTB1.Text;
            string localPatPassword = passwordTB2.Text;

            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            //CHECK IF USER IS A DOCTOR
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql_user = "SELECT username FROM crn_doctor WHERE username=@username";
                string sql_pass = "SELECT pword FROM crn_doctor WHERE pword=@pword";
                MySql.Data.MySqlClient.
                MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(sql_user, conn);
                MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(sql_pass, conn);
                cmd1.Parameters.AddWithValue("@username", localDOCUsername);
                cmd2.Parameters.AddWithValue("@pword", localDOCPassword);
                MySqlDataReader myUserReader = cmd1.ExecuteReader();
                MySqlDataReader myPassReader = cmd2.ExecuteReader();
                if (myUserReader.Read())
                {
                    usernameTB1.Text = myUserReader["username"].ToString();
                    
                }
                myUserReader.Close();

                if (myPassReader.Read())
                {
                    passwordTB2.Text = myPassReader["pword"].ToString();

                }
                myPassReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //END CHECKING FOR DOCTOR-----------------------------------------------
            Console.WriteLine("Done.");


            //CHECK IF USER IS A PATIENT
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql_user = "SELECT username FROM crn_patient WHERE username=@username";
                string sql_pass = "SELECT pword FROM crn_patient WHERE pword=@pword";
                MySql.Data.MySqlClient.
                MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(sql_user, conn);
                MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(sql_pass, conn);
                cmd1.Parameters.AddWithValue("@username", localPatUsername);
                cmd2.Parameters.AddWithValue("@pword", localPatPassword);
                MySqlDataReader myUserReader = cmd1.ExecuteReader();
                MySqlDataReader myPassReader = cmd2.ExecuteReader();
                if (myUserReader.Read())
                {
                    usernameTB1.Text = myUserReader["username"].ToString();
                }
                myUserReader.Close();

                if (myPassReader.Read())
                {
                    passwordTB2.Text = myPassReader["pword"].ToString();
                }
                myPassReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //END CHECKING FOR PATIENT-----------------------------------------------
            Console.WriteLine("Done.");


            //CHECK IF USER IS A PHARMACIST @ PHARMACY
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql_user = "SELECT username FROM crn_pharmacy WHERE username=@username";
                string sql_pass = "SELECT pword FROM crn_pharmacy WHERE pword=@pword";
                MySql.Data.MySqlClient.
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql_user, conn);
                cmd.Parameters.AddWithValue("@username", localPharmUsername);
                cmd.Parameters.AddWithValue("@pword", localPharmPassword);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    usernameTB1.Text = myReader["username"].ToString();
                    passwordTB2.Text = myReader["pword"].ToString();
                }
                myReader.Close();
                if (localPharmUsername.Equals("username"))
                {
                    if (localPharmPassword.Equals("pword"))
                    {
                        //pharmHome newpharmHomePage = new pharmHome();
                        //newpharmHomePage.FormClosed += new FormClosedEventHandler(newDocHomePageClosed);
                        //newpharmHomePage.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //END CHECKING FOR PHARMACIST @ PHARMACY-----------------------------------------------
            Console.WriteLine("Done.");

            
            //DOCTOR if
            if (localDOCUsername.Equals(""))
            {
                if (localDOCPassword.Equals(""))
                {
                    docHome newDocHomePage = new docHome();
                    newDocHomePage.FormClosed += new FormClosedEventHandler(newDocHomePageClosed);
                    newDocHomePage.Show();
                    this.Hide();
                }

            }
            //PATIENT if
            if (localDOCUsername.Equals("Pat"))
            {

                patHome newPatHomePage = new patHome();
                newPatHomePage.FormClosed += new FormClosedEventHandler(newPatHomePageClosed);
                newPatHomePage.Show();
                this.Hide();


            }
            //Pharmacy if
            if (localDOCUsername.Equals("Pharm"))
            {

                pharmHome newPharmHomePage = new pharmHome();
                newPharmHomePage.FormClosed += new FormClosedEventHandler(newPharmHomePageClosed);
                newPharmHomePage.Show();
                this.Hide();


            }



        }

        //should only come back when loging out, not closing program?
        void newDocHomePageClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //should only come back when loging out, not closing program?
        void newPatHomePageClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        void newPharmHomePageClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void usernameTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

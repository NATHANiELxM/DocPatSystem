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
        public MySqlDataReader read;
        public int currentUserID, ID;
        int cnt = 0;
        public login()
        {
            InitializeComponent();
            
        }
        
        // login button, I was going to rename it but it was messing up the design side
        // For Testing "Dr" goes to doctor page and "Pat" goes to patient
        private void Button1_Click(object sender, EventArgs e)
        {
            string localUsername = usernameTB1.Text;
            string localPassword = passwordTB2.Text;

            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            //DOCTOR TRY
            try
            {

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();

                string sql = "SELECT DOC_ID FROM crn_doctor WHERE username = @username and pword = @password";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", localUsername);
                cmd.Parameters.AddWithValue("@password", localPassword);

                using (read = cmd.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        // you can also use the else if statements here for the user privileges
                        
                        usernameTB1.Text = "";
                        passwordTB2.Text = "";

                        docHome newDocHomePage = new docHome();
                        newDocHomePage.FormClosed += new FormClosedEventHandler(newDocHomePageClosed);
                        newDocHomePage.Show();
                        this.Hide();
                        while (read.Read())
                        {       // get and save ID for the rest of the program
                            int ID = Int32.Parse(read["DOC_ID"].ToString());
                        }
                    }
                    else
                    {
                        cnt++;
                    }
                }

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            conn.Close();
            Console.WriteLine("Done.");


            //PATIENT TRY
            try
            {

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();

                string sql = "SELECT PATIENT_ID FROM crn_patient WHERE username = @username and pword = @password";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", localUsername);
                cmd.Parameters.AddWithValue("@password", localPassword);

                using (read = cmd.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        // you can also use the else if statements here for the user privileges

                        usernameTB1.Text = "";
                        passwordTB2.Text = "";

                        patHome newPatHomePage = new patHome();
                        newPatHomePage.FormClosed += new FormClosedEventHandler(newPatHomePageClosed);
                        newPatHomePage.Show();
                        this.Hide();
                        while (read.Read())
                        {       // get and save ID for the rest of the program
                            int ID = Int32.Parse(read["PATIENT_ID"].ToString());
                        }
                    }
                    else
                    {
                        cnt++;
                    }
                }

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            conn.Close();
            Console.WriteLine("Done.");




            //PHARMACY TRY
            try
            {

                Console.WriteLine("Connecting to MySQL...");

                conn.Open();

                string sql = "SELECT ID FROM crn_pharmacist WHERE username = @username and pword = @password";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", localUsername);
                cmd.Parameters.AddWithValue("@password", localPassword);

                using (read = cmd.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        // you can also use the else if statements here for the user privileges

                        usernameTB1.Text = "";
                        passwordTB2.Text = "";

                        pharmHome newPharmHomePage = new pharmHome();
                        newPharmHomePage.FormClosed += new FormClosedEventHandler(newPharmHomePageClosed);
                        newPharmHomePage.Show();
                        this.Hide();
                        while (read.Read())
                        {       // get and save ID for the rest of the program
                            int ID = Int32.Parse(read["ID"].ToString());
                        }
                    }
                    else
                    {
                        cnt++;
                    }
                }

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            conn.Close();
            Console.WriteLine("Done.");

            if(cnt >= 3)
            {
                cnt = 0;
                MessageBox.Show("Please enter valid login info", "Wrong username or password");
            }

            currentUserID = ID;
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

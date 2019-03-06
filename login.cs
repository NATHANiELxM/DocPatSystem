using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String user = usernameTB1.Text;
            //This will get the info from the username and password fields and check with the database is they are correct
            // By username, it will determine if it goes to doctor or patient page.
            //If user if doctor...
            if (user.Equals("Dr"))
            {
                docHome newDocHomePage = new docHome();
                newDocHomePage.FormClosed += new FormClosedEventHandler(newDocHomePageClosed);
                newDocHomePage.Show();
                this.Hide();
            }
            /*if (user.Equals("Pharm"))
            {
                pharmHome newpharmHomePage = new pharmHome();
                newpharmHomePage.FormClosed += new FormClosedEventHandler(newDocHomePageClosed);
                newpharmHomePage.Show();
                this.Hide();
            }*/
            if (user.Equals("Pat"))
            {
                patHome newPatHomePage = new patHome();
                newPatHomePage.FormClosed += new FormClosedEventHandler(newPatHomePageClosed);
                newPatHomePage.Show();
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

        private void usernameTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

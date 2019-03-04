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
    public partial class viewRecord : Form
    {
        public viewRecord()
        {
            InitializeComponent();
        }

        private void accessButt_Click(object sender, EventArgs e)
        {
            Doc.drGrantAccess newDrGrantAccessPage = new Doc.drGrantAccess();
            newDrGrantAccessPage.FormClosed += new FormClosedEventHandler(newDrGrantAccessPageClosed);
            newDrGrantAccessPage.Show();
            this.Hide();
        }
        void newDrGrantAccessPageClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}

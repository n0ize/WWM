using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsWWM
{
    public partial class FragenGUI : Form
    {
        StartGUI sg;
        OleDbDataReader dr;
        OleDbConnection con;
        public FragenGUI(StartGUI sg)
        {
            InitializeComponent();
            this.sg = sg;
            con = new OleDbConnection(Properties.Settings.Default.con);
            con.Open();
        }

        private void buttonMenü_Click(object sender, EventArgs e)
        {
            sg.Visible = true;
            this.Visible = false;
        }

        private void check(OleDbDataReader dr)
        {

        }
    }
}

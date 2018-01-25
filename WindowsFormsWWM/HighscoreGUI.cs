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
    public partial class HighscoreGUI : Form
    {
        public HighscoreGUI()
        {
            InitializeComponent();
            einlesen();
        }

        public void einlesen()
        {
            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.con);
            con.Open();

        }

        public Object check(DataReader dr)
        {

        }
    }
}

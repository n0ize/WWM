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
        List<Frage> listFragen = new List<Frage>();
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

        private void einlesen()
        {
            OleDbCommand com;
            com = con.CreateCommand();
            com.CommandText = "Fragen";
            com.CommandType = CommandType.TableDirect;
            OleDbDataReader dr = com.ExecuteReader();

            while (dr.Read() == true)
            {
                listFragen.Add(Frageerstellen(dr));
            }
            comboBoxTeilnehmer.DataSource = null;
            comboBoxTeilnehmer.DataSource = listFragen;
            con.Close();
        }

        public Frage Frageerstellen(OleDbDataAdapter dr)
        {
            Frage f = new Frage();
            int i = 0;

            f.Id = Convert.ToInt32(check(dr[i++]));
            f.FrageText = Convert.ToString(check(dr[i++]));
            f.Antwortarray[0] = Convert.ToString(check(dr[i++]));
            f.Antwortarray[1] = Convert.ToString(check(dr[i++]));
            f.Antwortarray[2] = Convert.ToString(check(dr[i++]));
            f.Antwortarray[3] = Convert.ToString(check(dr[i++]));
            f.Schwierigkeit = Convert.ToInt32(check(dr[i++]));

            return f;
        }
        private object check(object o)
        {
            if (o != DBNull.Value)
            {
                return o;
            }
            else
            {
                return null;
            }
        }
    }
}

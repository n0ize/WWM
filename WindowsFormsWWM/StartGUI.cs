using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWWM
{
    public partial class StartGUI : Form
    {
        public StartGUI()
        {
            InitializeComponent();
        }

        private void buttonHighscore_Click(object sender, EventArgs e)
        {
            Highscore hs = new Highscore();
            hs.Visible = true;
            this.Visible = false;
        }

        private void buttonSpielStart_Click(object sender, EventArgs e)
        {
            FormFragen ff = new FormFragen();
            ff.Visible = true;
            this.Visible = false;
        }
    }
}

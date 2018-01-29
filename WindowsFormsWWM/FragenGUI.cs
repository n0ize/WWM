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
    public partial class FragenGUI : Form
    {
        StartGUI sg;
        public FragenGUI(StartGUI sg)
        {
            InitializeComponent();
            this.sg = sg;
        }

        private void buttonMenü_Click(object sender, EventArgs e)
        {
            sg.Visible = true;
            this.Visible = false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Simulator
{
    public partial class ResistanceForm : Form
    {
        public string Resistance;
        public string Immunities;

        public ResistanceForm(ref string resistance, ref string immunities)
        {
            InitializeComponent();
            this.Resistance = resistance;
            this.Immunities = immunities;
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

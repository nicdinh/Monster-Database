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
    public partial class StatsForm : Form
    {
        public int[] Stats;
        public StatsForm()
        {
            InitializeComponent();
        }

        public StatsForm(string name, ref int [] stats)
        {
            InitializeComponent();
            this.NameLabel.Text = name;
            this.Stats = stats;
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            DataGridViewRow row=this.StatsInput.Rows[0];
            Stats[0] = Convert.ToInt16(row.Cells["Str"].Value);
            Stats[1] = Convert.ToInt16(row.Cells["Dex"].Value);
            Stats[2] = Convert.ToInt16(row.Cells["Con"].Value);
            Stats[3] = Convert.ToInt16(row.Cells["Int"].Value);
            Stats[4] = Convert.ToInt16(row.Cells["Wis"].Value);
            Stats[5] = Convert.ToInt16(row.Cells["Char"].Value);
            this.Close();
        }
    }
}

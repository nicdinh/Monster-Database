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

        public StatsForm(string name, int[] stats, ref int[] throws)
        {
            InitializeComponent();
            this.NameLabel.Text = name;
            this.Stats = throws;
            DataGridViewRow row = (DataGridViewRow)StatsInput.Rows[0].Clone();
            row.Cells[0].Value = Math.Floor((stats[0] - 10.0) / 2);
            row.Cells[1].Value = Math.Floor((stats[1] - 10.0) / 2);
            row.Cells[2].Value = Math.Floor((stats[2] - 10.0) / 2);
            row.Cells[3].Value = Math.Floor((stats[3] - 10.0) / 2);
            row.Cells[4].Value = Math.Floor((stats[4] - 10.0) / 2);
            row.Cells[5].Value = Math.Floor((stats[5] - 10.0) / 2);
            this.StatsInput.Rows.Add(row);
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

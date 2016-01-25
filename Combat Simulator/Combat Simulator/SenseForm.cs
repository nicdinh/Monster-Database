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
    public partial class SenseForm : Form
    {
        public string output = "";
        public SenseForm()
        {
            InitializeComponent();
        }

        public void BlindChecked(object sender, System.EventArgs e)
        {
            this.BlindRange.Visible = this.BlindSight.Checked;
            this.SenseRangeLabel.Visible = this.Tremorsense.Checked || this.BlindSight.Checked;
        }

        public void DarkChecked(object sender, System.EventArgs e)
        {
            this.DarkRange.Visible = this.DarkVision.Checked;
            this.SenseRangeLabel2.Visible = this.DarkVision.Checked || this.TrueSight.Checked;
        }

        public void TremorsenseChecked(object sender, System.EventArgs e)
        {
            this.TremorsenseRange.Visible = this.Tremorsense.Checked;
            this.SenseRangeLabel.Visible = this.Tremorsense.Checked || this.BlindSight.Checked;
        }

        public void TrueChecked(object sender, System.EventArgs e)
        {
            this.TrueRange.Visible = this.TrueSight.Checked;
            this.SenseRangeLabel2.Visible = this.DarkVision.Checked || this.TrueSight.Checked;
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            if(this.BlindSight.Checked)
            {
                output += "Blind Sight " + this.BlindRange.Text;
            }

            if (this.DarkVision.Checked)
            {
                if(output=="")
                {
                    output += "Dark Vision " + this.DarkRange.Text;
                }
                else
                {
                    output += ", Dark Vision " + this.DarkRange.Text;
                }
            }

            if (this.Tremorsense.Checked)
            {
                if (output == "")
                {
                    output += "Tremorsense " + this.TremorsenseRange.Text;
                }
                else
                {
                    output += ", Tremorsense " + this.TremorsenseRange.Text;
                }
            }

            if (this.TrueSight.Checked)
            {
                if (output == "")
                {
                    output += "True Sight " + this.TrueRange.Text;
                }
                else
                {
                    output += ", True Sight " + this.TrueRange.Text;
                }
            }
            if (output == "")
            {
                output += "Passive Perception " + this.Passive.Text;
            }
            else
            {
                output += ", Passive Perception " + this.Passive.Text;
            }

            this.Close();
        }
    }
}

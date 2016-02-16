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
    public partial class SpellDisplayForm : Form
    {
        public SpellDisplayForm(Spells input)
        {
            InitializeComponent();
            this.SpellName.Text = input.Name + " (pg " + input.PageNum + ")";
            if (input.Level>4)
            {
                this.School.Text = input.Level + "th-Level " + input.School;
            }
            else if (input.Level == 1)
            {
                this.School.Text = input.Level + "st-Level " + input.School;
            }
            else if (input.Level == 2)
            {
                this.School.Text = input.Level + "nd-Level " + input.School;
            }
            else if (input.Level == 3)
            {
                this.School.Text = input.Level + "rd-Level " + input.School;
            }
            else
            {
                this.School.Text = input.School + " Cantrip";
            }
            this.Cast.Text = "Cast Time: " + input.CastTime;
            this.Range.Text = "Range: " + input.Range;
            if (input.Verbal)
            {
                this.Component.Text = "V";
            }
            if (input.Somatic)
            {
                if (this.Component.Text=="")
                {
                    this.Component.Text = "S";
                }
                else
                {
                    this.Component.Text += ", S";
                }
            }
            if (input.Material.Length != 0)
            {
                if (this.Component.Text == "")
                {
                    this.Component.Text = "M (" + input.Material + ")";
                }
                else
                {
                    this.Component.Text += ", M (" + input.Material + ")";
                }
            }

            this.Duration.Text = "Duration: " + input.Duration;
            this.Info.Text = input.Info;
        }
    }
}

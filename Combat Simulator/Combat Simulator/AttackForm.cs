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
    public partial class AttackForm : Form
    {
        public Actions AllActions;

        public AttackForm(ref Actions input)
        {
            InitializeComponent();
            AllActions = input;
        }

        private void MeleeButtonChange(object sender, EventArgs e)
        {
            if (MeleeButton.Checked == true)
            {
                MaxLabel.Visible = false;
                MaxInput.Visible = false;
            }
            else
            {
                MaxLabel.Visible = true;
                MaxInput.Visible = true;
            }
        }

        private void DoneClick(object sender, EventArgs e)
        {
            if(MeleeButton.Checked==true)
            {
                AllActions.AddMeleeAttack(this.NameInput.Text,
                    int.Parse(this.AttackModInput.Text),
                    this.DamageInput.Text + " " + this.DamageDice.Text + " " + this.DamageType,
                    int.Parse(this.NormalInput.Text),
                    this.Info.Text);
            }
            else
            {
                AllActions.AddRangeAttack(this.NameInput.Text, 
                    int.Parse(this.AttackModInput.Text), 
                    int.Parse(this.NormalInput.Text), 
                    int.Parse(this.MaxInput.Text),
                    this.DamageInput.Text + " " + this.DamageDice.Text + " " + this.DamageType,
                    this.Info.Text);
            }

            this.Close();
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (MeleeButton.Checked == true)
            {
                AllActions.AddMeleeAttack(this.NameInput.Text,
                    int.Parse(this.AttackModInput.Text),
                    this.DamageInput.Text + " " + this.DamageDice.Text + " " + this.DamageType,
                    int.Parse(this.NormalInput.Text),
                    this.Info.Text);
            }
            else
            {
                AllActions.AddRangeAttack(this.NameInput.Text,
                    int.Parse(this.AttackModInput.Text),
                    int.Parse(this.NormalInput.Text),
                    int.Parse(this.MaxInput.Text),
                    this.DamageInput.Text + " " + this.DamageDice.Text + " " + this.DamageType,
                    this.Info.Text);
            }

            this.NameInput.Text = "";
            this.AttackModInput.Text = "";
            this.DamageInput.Text = "";
            this.NormalInput.Text = "";
            this.MaxInput.Text = "";
        }
    }
}

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
            if(this.ResisAcid.Checked)
            {this.Resistance += "Acid ";}
            if(this.ResisBludgeoning.Checked)
            {this.Resistance += "Bludgeoning ";}
            if(this.ResisCold.Checked)
            {this.Resistance += "Cold ";}
            if(this.ResisFire.Checked)
            {this.Resistance += "Fire ";}
            if(this.ResisForce.Checked)
            {this.Resistance += "Force ";}
            if(this.ResisLightning.Checked)
            {this.Resistance += "Lightning ";}
            if(this.ResisNecrotic.Checked)
            {this.Resistance += "Necrotic ";}
            if(this.ResisPiercing.Checked)
            {this.Resistance += "Piercing ";}
            if(this.ResisPoison.Checked)
            {this.Resistance += "Poison ";}
            if(this.ResisPsychic.Checked)
            {this.Resistance += "Psychic ";}
            if(this.ResisRadiant.Checked)
            {this.Resistance += "Radiant ";}
            if(this.ResisSlashing.Checked)
            {this.Resistance += "Slashing ";}
            if(this.ResisThunder.Checked)
            {this.Resistance += "Thunder ";}
           
            if(this.ImmAcid.Checked)
            {this.Immunities += "Acid ";}
            if(this.ImmBludgeoning.Checked)
            {this.Immunities += "Bludgeoning ";}
            if(this.ImmCold.Checked)
            {this.Immunities += "Cold ";}
            if(this.ImmFire.Checked)
            {this.Immunities += "Fire ";}
            if(this.ImmForce.Checked)
            {this.Immunities += "Force ";}
            if(this.ImmLightning.Checked)
            {this.Immunities += "Lightning ";}
            if(this.ImmNecrotic.Checked)
            {this.Immunities += "Necrotic ";}
            if(this.ImmPiercing.Checked)
            {this.Immunities += "Piercing ";}
            if(this.ImmPoison.Checked)
            {this.Immunities += "Poison ";}
            if(this.ImmPsychic.Checked)
            {this.Immunities += "Psychic ";}
            if(this.ImmRadiant.Checked)
            {this.Immunities += "Radiant ";}
            if(this.ImmSlashing.Checked)
            {this.Immunities += "Slashing ";}
            if(this.ImmThunder.Checked)
            {this.Immunities += "Thunder ";}

            this.Close();
        }
    }
}

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
        public string Conditions;

        public ResistanceForm(ref string resistance, ref string immunities, ref string conditions)
        {
            InitializeComponent();
            this.Resistance = resistance;
            this.Immunities = immunities;
            this.Conditions = conditions;
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

            if(this.CondBlinded.Checked)
            { this.Conditions += "Blinded "; }
            if (this.CondCharmed.Checked)
            { this.Conditions += "Charmed "; }
            if (this.CondDeafened.Checked)
            { this.Conditions += "Deafened "; }
            if (this.CondFrightened.Checked)
            { this.Conditions += "Frightened "; }
            if (this.CondGrappled.Checked)
            { this.Conditions += "Grappled "; }
            if (this.CondIncapacitated.Checked)
            { this.Conditions += "Incapacitated "; }
            if (this.CondInvisible.Checked)
            { this.Conditions += "Invisible "; }
            if (this.CondParalyzed.Checked)
            { this.Conditions += "Paralyzed "; }
            if (this.CondPetrified.Checked)
            { this.Conditions += "Petrified "; }
            if (this.CondPoisoned.Checked)
            { this.Conditions += "Poisoned "; }
            if (this.CondProne.Checked)
            { this.Conditions += "Prone "; }
            if (this.CondRestrained.Checked)
            { this.Conditions += "Restrained "; }
            if (this.CondStunned.Checked)
            { this.Conditions += "Stunned "; }
            if (this.CondUnconscious.Checked)
            { this.Conditions += "Unconscious "; }

            this.Close();
        }
    }
}

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
    public partial class LanguageForm : Form
    {
        public string Languages;

        public LanguageForm(ref string input)
        {
            InitializeComponent();
            this.Languages = input;
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            if(this.CommonInput.Checked)
            {Languages += "Common ";}
            if (this.DwarvishInput.Checked)
            {Languages += "Dwarvish ";}
            if (this.ElvishInput.Checked)
            {Languages += "Elvish ";}
            if (this.GiantInput.Checked)
            {Languages += "Giant ";}
            if (this.GnomishInput.Checked)
            {Languages += "Gnomish ";}
            if (this.GoblinInput.Checked)
            {Languages += "Goblin ";}
            if (this.HalflingInput.Checked)
            {Languages += "Halfling ";}
            if (this.OrcInput.Checked)
            {Languages += "Orc ";}
            if (this.AbyssalInput.Checked)
            {Languages += "Abyssal ";}
            if (this.CelestialInput.Checked)
            {Languages += "Celestial ";}
            if (this.DeepInput.Checked)
            {Languages += "Deep Speech ";}
            if (this.InfernalInput.Checked)
            {Languages += "Infernal ";}
            if (this.PrimordialInput.Checked)
            {Languages += "Primordial ";}
            if (this.DwarvishInput.Checked)
            {Languages += "Sylvan ";}
            if (this.SylvanInput.Checked)
            {Languages += "Dwarvish ";}
            if (this.UnderInput.Checked)
            {Languages += "Undercommon ";}

            Languages += this.Other.Text;

            this.Close();
        }
    }
}

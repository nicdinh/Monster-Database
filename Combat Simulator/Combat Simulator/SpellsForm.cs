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
    public partial class SpellsForm : Form
    {
        public Actions AllActions;
        public int SpellLevel;
        public int[] Slots;

        public SpellsForm(ref Actions Input)
        {
            InitializeComponent();

            this.AllActions = Input;
            this.Slots = Input.SpellSlots;
        }

        private void LevelChange(object sender, System.EventArgs e)
        {
            if(this.LevelList.Text=="Cantrip")
            {
                this.LevelInput.Text = "0";
                SpellLevel = 0;
                this.SlotsLabel.Text = "Cantrips Slots";
                this.SlotsInput.Text = "Infinite";
            }
            else if (this.LevelList.Text == "Level 1")
            {
                this.LevelInput.Text = "1";
                SpellLevel = 1;
                this.SlotsLabel.Text = "Level 1 Slots";
                this.SlotsInput.Text = "" + Slots[1];
            }
            else if (this.LevelList.Text == "Level 2")
            {
                this.LevelInput.Text = "2";
                SpellLevel = 2;
                this.SlotsLabel.Text = "Level 2 Slots";
                this.SlotsInput.Text = "" + Slots[2];
            }
            else if (this.LevelList.Text == "Level 3")
            {
                this.LevelInput.Text = "3";
                SpellLevel = 3;
                this.SlotsLabel.Text = "Level 3 Slots";
                this.SlotsInput.Text = "" + Slots[3];
            }
            else if (this.LevelList.Text == "Level 4")
            {
                this.LevelInput.Text = "4";
                SpellLevel = 4;
                this.SlotsLabel.Text = "Level 4 Slots";
                this.SlotsInput.Text = "" + Slots[4];
            }
            else if (this.LevelList.Text == "Level 5")
            {
                this.LevelInput.Text = "5";
                SpellLevel = 5;
                this.SlotsLabel.Text = "Level 5 Slots";
                this.SlotsInput.Text = "" + Slots[5];
            }
            else if (this.LevelList.Text == "Level 6")
            {
                this.LevelInput.Text = "6";
                SpellLevel = 6;
                this.SlotsLabel.Text = "Level 6 Slots";
                this.SlotsInput.Text = "" + Slots[6];
            }
            else if (this.LevelList.Text == "Level 7")
            {
                this.LevelInput.Text = "7";
                SpellLevel = 7;
                this.SlotsLabel.Text = "Level 7 Slots";
                this.SlotsInput.Text = "" + Slots[7];
            }
            else if (this.LevelList.Text == "Level 8")
            {
                this.LevelInput.Text = "8";
                SpellLevel = 8;
                this.SlotsLabel.Text = "Level 8 Slots";
                this.SlotsInput.Text = "" + Slots[8];
            }
            else if (this.LevelList.Text == "Level 9")
            {
                this.LevelInput.Text = "9";
                SpellLevel = 9;
                this.SlotsLabel.Text = "Level 9 Slots";
                this.SlotsInput.Text = "" + Slots[9];
            }
        }

        private void SlotsChange(object sender, System.EventArgs e)
        {
            if (this.LevelList.Text == "Cantrip")
            {
                Slots[0] = -1;
            }
            else if (this.LevelList.Text == "Level 1")
            {
                Slots[1] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 2")
            {
                Slots[2] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 3")
            {
                Slots[3] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 4")
            {
                Slots[4] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 5")
            {
                Slots[5] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 6")
            {
                Slots[6] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 7")
            {
                Slots[7]= int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 8")
            {
                Slots[8] = int.Parse(this.SlotsInput.Text);
            }
            else if (this.LevelList.Text == "Level 9")
            {
                Slots[9] = int.Parse(this.SlotsInput.Text);
            }
        }

        private void AddClick(object sender, System.EventArgs e)
        {
            Spells newSpell = new Spells(int.Parse(this.PageNum.Text), this.NameInput.Text, this.CastInput.Text,
                this.RangeInput.Text, this.MaterialInput.Text, this.VerbalInput.Checked, this.SomaticInput.Checked,
                this.RitualInput.Checked, this.Concentration.Checked, this.DurationInput.Text, this.School.Text,
                this.InfoInput.Text);

            if (this.LevelList.Text == "Cantrip")
            {
                Slots[0] = -1;
            }

            //AllActions.AddSpells(this.NameInput.Text,this.SpellLevel);
            AllActions.AddSpells(newSpell, this.SpellLevel);
            AllActions.AddSlots(this.Slots);
            AllActions.AddSpellMod(int.Parse(this.ModInput.Text), int.Parse(this.DCInput.Text));

            this.NameInput.Text = "";
            this.LevelInput.Text = "";
            this.LevelList.Text = "";
            this.SlotsInput.Text = "";
        }

        private void DoneClick(object sender, System.EventArgs e)
        {
            Spells newSpell = new Spells(int.Parse(this.PageNum.Text),this.NameInput.Text, this.CastInput.Text,
                this.RangeInput.Text,this.MaterialInput.Text, this.VerbalInput.Checked, this.SomaticInput.Checked,
                this.RitualInput.Checked,this.Concentration.Checked,this.DurationInput.Text,this.School.Text,
                this.InfoInput.Text);

            if (this.LevelList.Text == "Cantrip")
            {
                Slots[0] = -1;
            }

            //AllActions.AddSpells(this.NameInput.Text, this.SpellLevel);
            AllActions.AddSpells(newSpell, this.SpellLevel);
            AllActions.AddSlots(this.Slots);
            AllActions.AddSpellMod(int.Parse(this.ModInput.Text), int.Parse(this.DCInput.Text));

            this.Close();
        }

        public void MaterialChecked(object sender, System.EventArgs e)
        {
            if (this.MaterialCheck.Checked)
            {
                this.MaterialInput.Visible = true;
            }
            else
            {
                this.MaterialInput.Visible = false;
            }

        }
    }
}

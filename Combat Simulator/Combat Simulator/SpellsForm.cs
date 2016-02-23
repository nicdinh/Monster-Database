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
        public Database newData;
        public bool Loaded = false;
        public Spells LoadedSpell;
        private ErrorForm err;

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

        private void ChangeSchool(object sender, System.EventArgs e)
        {

            if (this.School.Text.Length > 1)
            {
                string temp = this.School.Text.ToLower();
                if (temp[0] == 'a')
                {
                    this.School.Text = "Abjuration";

                }
                else if (temp[0] == 'c')
                {
                    this.School.Text = "Conjuration";

                }
                else if (temp[0] == 'd')
                {
                    this.School.Text = "Divination";

                }
                else if (temp[0] == 'e')
                {
                    if (this.School.Text.Length > 2)
                    {
                        if (this.School.Text[1] == 'n')
                        {
                            this.School.Text = "Enchantment";
                        }
                        else if (this.School.Text[1] == 'v')
                        {
                            this.School.Text = "Evocation";
                        }
                    }

                }
                else if (temp[0] == 'i')
                {
                    this.School.Text = "Illusion";

                }
                else if (temp[0] == 'n')
                {
                    this.School.Text = "Necromancy";

                }
                else if (temp[0] == 't')
                {
                    this.School.Text = "Transmutation";

                }
            }
        }

        private void AddClick(object sender, System.EventArgs e)
        {
            if (!Loaded)
            {
                Spells newSpell = new Spells(int.Parse(this.PageNum.Text), this.NameInput.Text, this.SpellLevel, this.CastInput.Text,
                    this.RangeInput.Text, this.MaterialInput.Text, this.VerbalInput.Checked, this.SomaticInput.Checked,
                    this.RitualInput.Checked, this.Concentration.Checked, this.DurationInput.Text, this.School.Text,
                    this.InfoInput.Text);

                if (this.LevelList.Text == "Cantrip")
                {
                    Slots[0] = -1;
                }

                AllActions.AddSpells(newSpell, this.SpellLevel);
                AllActions.AddSlots(this.Slots);
                if (this.ModInput.Text != "" && this.DCInput.Text != "")
                {
                    AllActions.AddSpellMod(int.Parse(this.ModInput.Text), int.Parse(this.DCInput.Text));
                }


                newData.AddSpell(newSpell, true);

                //SpellDisplayForm test = new SpellDisplayForm(newSpell);
                //test.Show();
            }
            this.NameInput.Text = "";
            this.PageNum.Text = "";
            this.School.Text = "";
            this.CastInput.Text = "";
            this.RangeInput.Text = "";
            this.DurationInput.Text = "";
            this.RitualInput.Checked = false;
            this.Concentration.Checked = false;
            this.VerbalInput.Checked = false;
            this.SomaticInput.Checked = false;
            this.MaterialCheck.Checked = false;
            this.MaterialInput.Visible = false;
            this.MaterialInput.Text = "";
            this.InfoInput.Text = "";
        }

        private void DoneClick(object sender, System.EventArgs e)
        {
            if (!Loaded)
            {
                if ((this.PageNum.Text != "" && this.NameInput.Text != "" && this.CastInput.Text != "" && this.RangeInput.Text != "" &&
                     this.DurationInput.Text != "" && this.School.Text != "" && this.InfoInput.Text != "") &&
                    (this.VerbalInput.Checked || this.SomaticInput.Checked || this.MaterialCheck.Checked))
                {
                    Spells newSpell = new Spells(int.Parse(this.PageNum.Text), this.NameInput.Text, this.SpellLevel, this.CastInput.Text,
                        this.RangeInput.Text, this.MaterialInput.Text, this.VerbalInput.Checked, this.SomaticInput.Checked,
                        this.RitualInput.Checked, this.Concentration.Checked, this.DurationInput.Text, this.School.Text,
                        this.InfoInput.Text);

                    if (this.LevelList.Text == "Cantrip")
                    {
                        Slots[0] = -1;
                    }

                    AllActions.AddSpells(newSpell, this.SpellLevel);
                    AllActions.AddSlots(this.Slots);
                    if (this.ModInput.Text != "" && this.DCInput.Text != "")
                    {
                        AllActions.AddSpellMod(int.Parse(this.ModInput.Text), int.Parse(this.DCInput.Text));
                    }


                    newData.AddSpell(newSpell, true);
                    this.Close();
                }
                else
                {
                    if (this.PageNum.Text == "")
                    {
                        err = new ErrorForm(new Exception("Page number not filled"), "Please enter a number");
                    }
                    else if (this.NameInput.Text == "")
                    {
                        err = new ErrorForm(new Exception("Name not filled"), "Please enter a name");
                    }
                    else if (this.CastInput.Text == "")
                    {
                        err = new ErrorForm(new Exception("Cast time not filled"), "Please enter a cast time");
                    }
                    else if (this.RangeInput.Text == "")
                    {
                        err = new ErrorForm(new Exception("Range not filled"), "Please enter a range");
                    }
                    else if (this.DurationInput.Text == "")
                    {
                        err = new ErrorForm(new Exception("Duration not filled"), "Please enter a duration");
                    }
                    else if (this.School.Text == "")
                    {
                        err = new ErrorForm(new Exception("School not filled"), "Please enter a school");
                    }
                    else if (this.InfoInput.Text == "")
                    {
                        err = new ErrorForm(new Exception("Info not filled"), "Please enter additional info");
                    }
                    else if (!this.VerbalInput.Checked && !this.SomaticInput.Checked && !this.MaterialCheck.Checked)
                    {
                        err = new ErrorForm(new Exception("Component not filled"), "Please check either verbal, somatic or material");
                    }

                    err.Show();
                }

                //SpellDisplayForm test = new SpellDisplayForm(newSpell);
                //test.Show();
            }
        }

        public void LoadSpell(object sender, System.EventArgs e)
        {
            Spells newSpell = null;
            if (this.NameInput.Text.Length>0)
            {
                newSpell = newData.FindSpell(this.NameInput.Text);
            }

            if (newSpell != null)
            {
                this.LevelInput.Text = newSpell.Level.ToString();
                this.PageNum.Text = newSpell.PageNum.ToString();
                this.School.Text = newSpell.School;
                this.CastInput.Text = newSpell.CastTime;
                this.RangeInput.Text = newSpell.Range;
                this.DurationInput.Text = newSpell.Duration;
                this.RitualInput.Checked = newSpell.Ritual;
                this.Concentration.Checked = newSpell.Concentration;
                this.VerbalInput.Checked = newSpell.Verbal;
                this.SomaticInput.Checked = newSpell.Somatic;
                if (newSpell.Material != null)
                {
                    this.MaterialCheck.Checked = true;
                    this.MaterialInput.Text = newSpell.Material;
                }
                this.InfoInput.Text = newSpell.Info;
                Loaded = true;
                LoadedSpell = newSpell;
            }
        }


        private void FormLoad(object sender, System.EventArgs e)
        {
            newData = new Database();
            newData.LoadDatabaseSpells();
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

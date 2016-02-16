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
    public partial class LoadSpells : Form
    {
        public Database newData;
        public Actions AllActions;
        public Spells newSpell;
        public LoadSpells(ref Actions input)
        {
            InitializeComponent();
            this.AllActions = input;
            newData = new Database();
            newData.LoadDatabaseSpells();
        }

        private void LetterChange(object sender, System.EventArgs e)
        {
            int letter;
            if (this.FirstLetter.Text.Length > 0)
            {
                letter = char.ToUpper(this.FirstLetter.Text[0]) - 64;
                this.SpellName.Items.Clear();
                if (newData.AllSpells[letter] != null)
                {
                    string[] name = new string[newData.AllSpells[letter].Length];

                    for (int x = 0; x < name.Length; x++)
                    {
                        name[x] = newData.AllSpells[letter][x].Name;
                    }

                    this.SpellName.Items.AddRange(name);
                }
            }
        }

        private void SpellChange(object sender, System.EventArgs e)
        {
            if (this.FirstLetter.Text.Length > 0)
            {
                int letter = char.ToUpper(this.FirstLetter.Text[0]) - 64;
                this.newSpell = newData.FindSpell(this.SpellName.Text);
            }
        }

        private void DisplayClick(object sender, System.EventArgs e)
        {
            SpellDisplayForm window = new SpellDisplayForm(newSpell);

            window.Show();
        }
        private void AddClick(object sender, System.EventArgs e)
        {
            AllActions.AddSpells(this.newSpell, this.newSpell.Level);
            this.FirstLetter.Text = "";
            this.SpellName.Text = "";
        }
        private void DoneClick(object sender, System.EventArgs e)
        {
            AllActions.AddSpells(this.newSpell, this.newSpell.Level);
            this.Close();
        }
    }
}

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
    public partial class SpellorAttackForm : Form
    {
        public Actions AllActions;

        public SpellorAttackForm(ref Actions Input)
        {
            InitializeComponent();
            this.AllActions = Input;
        }

        private void AttackClick(object sender, EventArgs e)
        {
            AttackForm window = new AttackForm(ref AllActions);

            window.Show();
            this.Close();
        }

        private void SpellClick(object sender, EventArgs e)
        {
            SpellsForm window = new SpellsForm(ref AllActions);

            window.Show();
            this.Close();
        }

        private void LegendaryClick(object sender, EventArgs e)
        {
            LegendaryForm window = new LegendaryForm(ref AllActions);

            window.Show();
            this.Close();
        }
        
        private void OldClick(object sender, EventArgs e)
        {
            LoadSpells window = new LoadSpells(ref AllActions);

            window.Show();
            this.Close();

        }
    }
}

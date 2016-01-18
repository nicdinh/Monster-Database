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
    public partial class CreateMonster : Form
    {
        public int Experience;
        public double Challenge;
        public Actions AllActions = new Actions();
        public Abilities AllAbility = new Abilities();
        //public ResistanceForm Resistancewindow;
        //public StatsForm Statswindow;
        //public ThrowForm Throwwindow;
        //public SkillForm Skillwindow;
        public CRForm CRwindow;
        public SpellorAttackForm Actionwindow;
        public AbilityForm Abilitywindow;
        //public PreviewForm Previewwindow;
        
        //public 


        public CreateMonster()
        {
            InitializeComponent();
        }

        public void AddResistancesClick(object sender, System.EventArgs e)
        {

        }

        public void AddStatsClick(object sender, System.EventArgs e)
        {

        }

        public void AddThrowClick(object sender, System.EventArgs e)
        {

        }

        public void AddSkillClick(object sender, System.EventArgs e)
        {

        }

        public void AddCRClick(object sender, System.EventArgs e)
        {
            CRwindow = new CRForm(ref Experience, ref Challenge);

            CRwindow.Show();
        }

        public void AddActionClick(object sender, System.EventArgs e)
        {
            Actionwindow = new SpellorAttackForm(ref AllActions);

            Actionwindow.Show();
        }

        public void AddAbilityClick(object sender, System.EventArgs e)
        {
            Abilitywindow = new AbilityForm();

            Abilitywindow.Show();
        }

        public void PreviewClick(object sender, System.EventArgs e)
        {

        }
        public void DoneClick(object sender, System.EventArgs e)
        {

            this.Close();
        }

    }
}

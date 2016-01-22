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
        public SkillsForm Skillswindow;
        public CRForm CRwindow;
        public SpellorAttackForm Actionwindow;
        public AbilityForm Abilitywindow;
        //public PreviewForm Previewwindow;

        public int[] Stats = new int[6];
        public int[] Throw = new int[6];
        public string Resistance;
        public string Immunities;
        public string Languages="";
        
        //public 


        public CreateMonster()
        {
            InitializeComponent();
        }

        public void AddResistancesClick(object sender, System.EventArgs e)
        {
            ResistanceForm Resistancewindow = new ResistanceForm(ref Resistance, ref Immunities);

            Resistancewindow.Show();
        }

        public void AddStatsClick(object sender, System.EventArgs e)
        {
            StatsForm Statswindow = new StatsForm("Stats Points",ref this.Stats);

            Statswindow.Show();
        }

        public void AddThrowClick(object sender, System.EventArgs e)
        {
            StatsForm Statswindow = new StatsForm("Throws Modifiers", this.Stats, ref this.Throw);

            Statswindow.Show();
        }

        public void AddSkillClick(object sender, System.EventArgs e)
        {
            Skillswindow = new SkillsForm(this.Stats);

            Skillswindow.Show();
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
            Abilitywindow = new AbilityForm(ref AllAbility);

            Abilitywindow.Show();
        }

        public void PreviewClick(object sender, System.EventArgs e)
        {

        }

        public void LanguageClick(object sender, System.EventArgs e)
        {
            LanguageForm languagewindow = new LanguageForm(ref Languages);

            languagewindow.Show();
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            /*
            public Monster(string Name,string Size, int AC, int Str, int Dex, int Con, int Int, int Wis, int Char, int Max, int Health, string Speed,
                        int Athletics, int Acrobatics, int Sleight, int Stealth, int Arcana, int History, int Investigation, int Nature,
                        int Religion, int Animal, int Insight, int Medicine, int Perception, int Survival, int Deception, int Intimidation,
                        int Performance, int Persuasion, string Language, string Resistance, string Immunity, string Sense)
             */

            /*Monster newMonster = new Monster(this.NameInput.Text, int.Parse(this.ACInput.Text), Stats[0], Stats[1] ,Stats[2], Stats[3], Stats[4], Stats[5],
                int.Parse(this.HealthInput.Text), int.Parse(this.HealthInput.Text), this.SpeedInput.Text, this.Skillswindow.Athletics, this.Skillswindow.Acrobatics,
                this.Skillswindow.Sleight, this.Skillswindow.Stealth, this.Skillswindow.Arcana, this.Skillswindow.History, this.Skillswindow.Investigation, 
                this.Skillswindow.Nature, this.Skillswindow.Religion, this.Skillswindow.Animal, this.Skillswindow.Insight, this.Skillswindow.Medicine,
                this.Skillswindow.Perception, this.Skillswindow.Survival, this.Skillswindow.Deception, this.Skillswindow.Intimidation, this.Skillswindow.Performance,
                this.Skillswindow.Persuasion, this.Languages, this.Resistance, this.Immunities, );*/

            this.Close();
        }

    }
}

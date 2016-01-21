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
    public partial class SkillsForm : Form
    {
        public int[] Stats;
        public int Athletics;
        public int Acrobatics;
        public int Arcana;
        public int History;
        public int Religion;
        public int Animal;
        public int Perception;
        public int Survival;
        public int Performance;
        public int Persuasion;
        public int Sleight;
        public int Stealth;
        public int Investigation;
        public int Nature;
        public int Insight;
        public int Medicine;
        public int Deception;
        public int Intimidation;
        public SkillsForm(int[] stats)
        {
            InitializeComponent();
            this.Stats = stats;

            double StrMod = Math.Floor((stats[0] - 10.0) / 2);
            double DexMod = Math.Floor((stats[1] - 10.0) / 2);
            double IntMod = Math.Floor((stats[3] - 10.0) / 2);
            double WisMod = Math.Floor((stats[4] - 10.0) / 2);
            double CharMod = Math.Floor((stats[5] - 10.0) / 2);

            Athletics = Convert.ToInt16(StrMod);
            this.AthleticsInput.Text = Athletics.ToString();

            Acrobatics = Convert.ToInt16(DexMod);
            this.AcrobaticsInput.Text = Acrobatics.ToString();
            Sleight = Convert.ToInt16(DexMod);
            this.SleightInput.Text = Sleight.ToString();
            Stealth = Convert.ToInt16(DexMod);
            this.StealthInput.Text = Stealth.ToString();

            Arcana = Convert.ToInt16(IntMod);
            this.ArcanaInput.Text = Arcana.ToString();
            History = Convert.ToInt16(IntMod);
            this.HistoryInput.Text = History.ToString();
            Investigation = Convert.ToInt16(IntMod);
            this.InvestigationInput.Text = Investigation.ToString();
            Nature = Convert.ToInt16(IntMod);
            this.NatureInput.Text = Nature.ToString();
            Religion = Convert.ToInt16(IntMod);
            this.ReligionInput.Text = Religion.ToString();

            Animal = Convert.ToInt16(WisMod);
            this.AnimalInput.Text = Animal.ToString();
            Insight = Convert.ToInt16(WisMod);
            this.InsightInput.Text = Insight.ToString();
            Medicine = Convert.ToInt16(WisMod);
            this.MedicineInput.Text = Medicine.ToString();
            Perception = Convert.ToInt16(WisMod);
            this.PerceptionInput.Text = Perception.ToString();
            Survival = Convert.ToInt16(WisMod);
            this.SurvivalInput.Text = Survival.ToString();

            Deception = Convert.ToInt16(CharMod);
            this.DeceptionInput.Text = Deception.ToString();
            Intimidation = Convert.ToInt16(CharMod);
            this.IntimidationInput.Text = Intimidation.ToString();
            Performance = Convert.ToInt16(CharMod);
            this.PerformanceInput.Text = Performance.ToString();
            Persuasion = Convert.ToInt16(CharMod);
            this.PersuasionInput.Text = Persuasion.ToString();
        }

        public void DoneClick(object sender, System.EventArgs e)
        {

            this.Close();
        }
    }
}

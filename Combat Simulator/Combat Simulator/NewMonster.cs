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
    public partial class NewMonster : Form
    {
        public DataGridView CombatLog;
        public int Experience;
        public double Challenge;
        public Actions AllActions = new Actions();
        public Abilities AllAbility = new Abilities();
        public CRForm CRwindow;
        public AbilityForm Abilitywindow;

        public NewMonster(ref DataGridView input)
        {
            InitializeComponent();
            CombatLog = input;
        }

        public NewMonster(ref DataGridView input, Monster checkMonster)
        {
            InitializeComponent(checkMonster);
            CombatLog = input;
        }


        public void DoneClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            //string Name, int AC, int Str, int Dex, int Con, int Int ,int Wis, int Char, int Max, int Health, string Speed

            if (this.StatsInput.Rows.Count != 0)
            {
                DataGridViewRow row = this.StatsInput.Rows[0];
                int Str = Convert.ToInt16(row.Cells["Str"].Value);
                int Dex = Convert.ToInt16(row.Cells["Dex"].Value);
                int Con = Convert.ToInt16(row.Cells["Con"].Value);
                int Int = Convert.ToInt16(row.Cells["Int"].Value);
                int Wis = Convert.ToInt16(row.Cells["Wis"].Value);
                int Char = Convert.ToInt16(row.Cells["Char"].Value);

                Monster newCreature = new Monster(this.NameInput.Text, this.SizeInput.Text, Convert.ToInt16(this.ACInput.Text), Str, Dex, Con, Int, Wis, Char,
                                                    Convert.ToInt16(this.HealthInput.Text), Convert.ToInt16(this.HealthInput.Text), this.SpeedInput.Text,
                                                    int.Parse(this.AthleticsInput.Text), int.Parse(this.AcrobaticsInput.Text), int.Parse(this.SleightInput.Text),
                                                    int.Parse(this.StealthInput.Text), int.Parse(this.ArcanaInput.Text), int.Parse(this.HistoryInput.Text),
                                                    int.Parse(this.InvestigationInput.Text), int.Parse(this.NatureInput.Text), int.Parse(this.ReligionInput.Text),
                                                    int.Parse(this.AnimalInput.Text), int.Parse(this.InsightInput.Text), int.Parse(this.MedicineInput.Text),
                                                    int.Parse(this.PerceptionInput.Text), int.Parse(this.SurvivalInput.Text), int.Parse(this.DeceptionInput.Text),
                                                    int.Parse(this.IntimidationInput.Text), int.Parse(this.PerformanceInput.Text), int.Parse(this.PersuasionInput.Text),
                                                    this.LanguagesInput.Text, this.ResistanceInput.Text, this.ImmunityInput.Text, this.SenseInput.Text);
            }
        }


        //        if (this.Abilitywindow.Throws==true)
        //        {
        //            int ThrowStr;
        //            int ThrowDex;
        //            int ThrowCon;
        //            int ThrowInt;
        //            int ThrowWis;
        //            int ThrowChar;

        //            if (this.Abilitywindow.ThrowStr!=-10)
        //            {
        //                ThrowStr = this.Abilitywindow.ThrowStr;
        //            }
        //            else
        //            {
        //                ThrowStr = (int)Math.Floor((Str - 10) / 2.0);
        //            }

        //            if (this.Abilitywindow.ThrowDex != -10)
        //            {
        //                ThrowDex = this.Abilitywindow.ThrowDex;
        //            }
        //            else
        //            {
        //                ThrowDex = (int)Math.Floor((Dex - 10) / 2.0);
        //            }

        //            if (this.Abilitywindow.ThrowCon != -10)
        //            {
        //                ThrowCon = this.Abilitywindow.ThrowCon;
        //            }
        //            else
        //            {
        //                ThrowCon = (int)Math.Floor((Con - 10) / 2.0);
        //            }

        //            if (this.Abilitywindow.ThrowInt != -10)
        //            {
        //                ThrowInt = this.Abilitywindow.ThrowInt;
        //            }
        //            else
        //            {
        //                ThrowInt = (int)Math.Floor((Int - 10) / 2.0);
        //            }

        //            if (this.Abilitywindow.ThrowWis != -10)
        //            {
        //                ThrowWis = this.Abilitywindow.ThrowWis;
        //            }
        //            else
        //            {
        //                ThrowWis = (int)Math.Floor((Wis - 10) / 2.0);
        //            }

        //            if (this.Abilitywindow.ThrowChar != -10)
        //            {
        //                ThrowChar = this.Abilitywindow.ThrowChar;
        //            }
        //            else
        //            {
        //                ThrowChar = (int)Math.Floor((Char - 10) / 2.0);
        //            }

        //            newCreature.AddThrow(ThrowStr, ThrowDex, ThrowCon, ThrowInt, ThrowWis, ThrowChar);
        //        }

        //        newCreature.AddCR(CRwindow.challenge, CRwindow.experience);

        //        CombatLog.Rows.Add(newCreature.ReturnArray());

        //        newCreature.AddAbility(AllAbility);

        //        newCreature.AddActions(AllActions);

        //        newCreature.EnterDatabase();
        //    }

        //    this.Close();
        //}

        public void CRClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            CRwindow = new CRForm(ref Experience, ref Challenge);


            CRwindow.Show();
        }

        public void ActionsClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            //AttackForm window = new AttackForm(ref AllActions);
            SpellorAttackForm window =new SpellorAttackForm(ref AllActions);

            window.Show();
        }
        public void AbilityClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            Abilitywindow = new AbilityForm();

            Abilitywindow.Show();
        }

        public void StatChange(object sender, System.EventArgs e)
        {
            if (this.StatsInput.Rows.Count != 0)
            {

                DataGridViewRow row = this.StatsInput.Rows[0];

                int Str = Convert.ToInt16(row.Cells["Str"].Value);
                int Dex = Convert.ToInt16(row.Cells["Dex"].Value);
                int Con = Convert.ToInt16(row.Cells["Con"].Value);
                int Int = Convert.ToInt16(row.Cells["Int"].Value);
                int Wis = Convert.ToInt16(row.Cells["Wis"].Value);
                int Char = Convert.ToInt16(row.Cells["Char"].Value);

                this.AthleticsInput.Text = "" + Math.Floor((Str - 10) / 2.0);

                this.AcrobaticsInput.Text =  "" + Math.Floor((Dex - 10) / 2.0);
                this.SleightInput.Text = "" + Math.Floor((Dex - 10) / 2.0);
                this.StealthInput.Text = "" + Math.Floor((Dex - 10) / 2.0);

                this.ArcanaInput.Text = "" + Math.Floor((Int - 10) / 2.0);
                this.HistoryInput.Text = "" + Math.Floor((Int - 10) / 2.0);
                this.InvestigationInput.Text = "" + Math.Floor((Int - 10) / 2.0);
                this.NatureInput.Text = "" + Math.Floor((Int - 10) / 2.0);
                this.ReligionInput.Text = "" + Math.Floor((Int - 10) / 2.0);

                this.AnimalInput.Text = "" + Math.Floor((Wis - 10) / 2.0);
                this.InsightInput.Text = "" + Math.Floor((Wis - 10) / 2.0);
                this.MedicineInput.Text = "" + Math.Floor((Wis - 10) / 2.0);
                this.PerceptionInput.Text = "" + Math.Floor((Wis - 10) / 2.0);
                this.SurvivalInput.Text = "" + Math.Floor((Wis - 10) / 2.0);

                this.DeceptionInput.Text = "" + Math.Floor((Char - 10) / 2.0);
                this.IntimidationInput.Text = "" + Math.Floor((Char - 10) / 2.0);
                this.PerformanceInput.Text = "" + Math.Floor((Char - 10) / 2.0);
                this.PersuasionInput.Text = "" + Math.Floor((Char - 10) / 2.0);
            }
        }
    }
}

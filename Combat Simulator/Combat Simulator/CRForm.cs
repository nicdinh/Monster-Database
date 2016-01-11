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
    public partial class CRForm : Form
    {
        public int experience;
        public double challenge;

        public CRForm(ref int experience, ref double challenge)
        {
            InitializeComponent();
            this.experience = experience;
            this.challenge = challenge;
        }

        private void ChallengeChange(object sender, System.EventArgs e)
        {
            // Add event handler code here.            
            if (this.CRList.Text=="Challenge 0")
            {
                this.CRInput.Text = "0";
                this.EXPInput.Text = "10";
                this.EXPList.Text = "10 XP";
            }
            else if (this.CRList.Text=="Challenge 1/8")
            {
                this.CRInput.Text = "0.125";
                this.EXPInput.Text = "25";
                this.EXPList.Text = "25 XP";
            }
            else if (this.CRList.Text=="Challenge 1/4")
            {
                this.CRInput.Text = "0.25";
                this.EXPInput.Text = "50";
                this.EXPList.Text = "50 XP";
            }
            else if (this.CRList.Text=="Challenge 1/2")
            {
                this.CRInput.Text = "0.5";
                this.EXPInput.Text = "100";
                this.EXPList.Text = "100 XP";

            }
            else if (this.CRList.Text=="Challenge 1")
            {
                this.CRInput.Text = "1";
                this.EXPInput.Text = "200";
                this.EXPList.Text = "200 XP";
            }
            else if (this.CRList.Text=="Challenge 2")
            {
                this.CRInput.Text = "2";
                this.EXPInput.Text = "450";
                this.EXPList.Text = "450 XP";
            }
            else if (this.CRList.Text=="Challenge 3")
            {
                this.CRInput.Text = "3";
                this.EXPInput.Text = "700";
                this.EXPList.Text = "700 XP";
            }
            else if (this.CRList.Text=="Challenge 4")
            {
                this.CRInput.Text = "4";
                this.EXPInput.Text = "1 100";
                this.EXPList.Text = "1 100 XP";
            }
            else if (this.CRList.Text=="Challenge 5")
            {
                this.CRInput.Text = "5";
                this.EXPInput.Text = "1 800";
                this.EXPList.Text = "1 800 XP";

            }
            else if (this.CRList.Text=="Challenge 6")
            {
                this.CRInput.Text = "6";
                this.EXPInput.Text = "2 300";
                this.EXPList.Text = "2 300 XP";
            }
            else if (this.CRList.Text=="Challenge 7")
            {
                this.CRInput.Text = "7";
                this.EXPInput.Text = "2 900";
                this.EXPList.Text = "2 900 XP";
            }
            else if (this.CRList.Text=="Challenge 8")
            {
                this.CRInput.Text = "8";
                this.EXPInput.Text = "3 900";
                this.EXPList.Text = "3 900 XP";
            }
            else if (this.CRList.Text=="Challenge 9")
            {
                this.CRInput.Text = "9";
                this.EXPInput.Text = "5 000";
                this.EXPList.Text = "5 000 XP";
            }
            else if (this.CRList.Text=="Challenge 10")
            {
                this.CRInput.Text = "10";
                this.EXPInput.Text = "5 900";
                this.EXPList.Text = "5 900 XP";
            }
            else if (this.CRList.Text=="Challenge 11")
            {
                this.CRInput.Text = "11";
                this.EXPInput.Text = "7 200";
                this.EXPList.Text = "7 200 XP";
            }
            else if (this.CRList.Text=="Challenge 12")
            {
                this.CRInput.Text = "12";
                this.EXPInput.Text = "8 400";
                this.EXPList.Text = "8 400 XP";
            }
            else if (this.CRList.Text=="Challenge 13")
            {
                this.CRInput.Text = "13";
                this.EXPInput.Text = "10 000";
                this.EXPList.Text = "10 000 XP";
            }
            else if (this.CRList.Text=="Challenge 14")
            {
                this.CRInput.Text = "14";
                this.EXPInput.Text = "11 500";
                this.EXPList.Text = "11 500 XP";
            }
            else if (this.CRList.Text=="Challenge 15")
            {
                this.CRInput.Text = "15";
                this.EXPInput.Text = "13 000";
                this.EXPList.Text = "13 000 XP";
            }
            else if (this.CRList.Text=="Challenge 16")
            {
                this.CRInput.Text = "16";
                this.EXPInput.Text = "15 000";
                this.EXPList.Text = "15 000 XP";
            }
            else if (this.CRList.Text=="Challenge 17")
            {
                this.CRInput.Text = "17";
                this.EXPInput.Text = "18 000";
                this.EXPList.Text = "18 000 XP";
            }
            else if (this.CRList.Text=="Challenge 18")
            {
                this.CRInput.Text = "18";
                this.EXPInput.Text = "20 000";
                this.EXPList.Text = "20 000 XP";
            }
            else if (this.CRList.Text=="Challenge 19")
            {
                this.CRInput.Text = "19";
                this.EXPInput.Text = "22 000";
                this.EXPList.Text = "22 000 XP";
            }
            else if (this.CRList.Text=="Challenge 20")
            {
                this.CRInput.Text = "20";
                this.EXPInput.Text = "25 000";
                this.EXPList.Text = "25 000 XP";
            }
            else if (this.CRList.Text=="Challenge 21")
            {
                this.CRInput.Text = "21";
                this.EXPInput.Text = "33 000";
                this.EXPList.Text = "33 000 XP";
            }
            else if (this.CRList.Text=="Challenge 22")
            {
                this.CRInput.Text = "22";
                this.EXPInput.Text = "41 000";
                this.EXPList.Text = "41 000 XP";
            }
            else if (this.CRList.Text=="Challenge 23")
            {
                this.CRInput.Text = "23";
                this.EXPInput.Text = "50 000";
                this.EXPList.Text = "50 000 XP";
            }
            else if (this.CRList.Text=="Challenge 24")
            {
                this.CRInput.Text = "24";
                this.EXPInput.Text = "62 000";
                this.EXPList.Text = "62 000 XP";
            }
            else if (this.CRList.Text=="Challenge 30")
            {
                this.CRInput.Text = "30";
                this.EXPInput.Text = "155 000";
                this.EXPList.Text = "155 000 XP";
            }
        }

        private void ExperienceChange(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            if (this.EXPList.Text == "10 XP")
            {
                this.CRInput.Text = "0";
                this.CRList.Text = "Challenge 0";
                this.EXPInput.Text = "10";
            }
            else if (this.EXPList.Text == "25 XP")
            {
                this.CRInput.Text = "0.125";
                this.CRList.Text = "Challenge 1/8";
                this.EXPInput.Text = "25";
            }
            else if (this.EXPList.Text == "50 XP")
            {
                this.CRInput.Text = "0.25";
                this.CRList.Text = "Challenge 1/4";
                this.EXPInput.Text = "50";
            }
            else if (this.EXPList.Text == "100 XP")
            {
                this.CRInput.Text = "0.5";
                this.CRList.Text = "Challenge 1/2";
                this.EXPInput.Text = "100";
            }
            else if (this.EXPList.Text == "200 XP")
            {
                this.CRInput.Text = "1";
                this.CRList.Text = "Challenge 1";
                this.EXPInput.Text = "200";
            }
            else if (this.EXPList.Text == "450 XP")
            {
                this.CRInput.Text = "2";
                this.CRList.Text = "Challenge 2";
                this.EXPInput.Text = "450";
            }
            else if (this.EXPList.Text == "700 XP")
            {
                this.CRInput.Text = "3";
                this.CRList.Text = "Challenge 3";
                this.EXPInput.Text = "700";
            }
            else if (this.EXPList.Text == "1 100 XP")
            {
                this.CRInput.Text = "4";
                this.CRList.Text = "Challenge 4";
                this.EXPInput.Text = "1 100";
            }
            else if (this.EXPList.Text == "1 800 XP")
            {
                this.CRInput.Text = "5";
                this.CRList.Text = "Challenge 5";
                this.EXPInput.Text = "1 800";
            }
            else if (this.EXPList.Text == "2 300 XP")
            {
                this.CRInput.Text = "6";
                this.CRList.Text = "Challenge 6";
                this.EXPInput.Text = "2 300";
            }
            else if (this.EXPList.Text == "2 900 XP")
            {
                this.CRInput.Text = "7";
                this.CRList.Text = "Challenge 7";
                this.EXPInput.Text = "2 900";
            }
            else if (this.EXPList.Text == "3 900 XP")
            {
                this.CRInput.Text = "8";
                this.CRList.Text = "Challenge 8";
                this.EXPInput.Text = "3 900";
            }
            else if (this.EXPList.Text == "5 000 XP")
            {
                this.CRInput.Text = "9";
                this.CRList.Text = "Challenge 9";
                this.EXPInput.Text = "5 000";
            }
            else if (this.EXPList.Text == "5 900 XP")
            {
                this.CRInput.Text = "10";
                this.CRList.Text = "Challenge 10";
                this.EXPInput.Text = "5 900";
            }
            else if (this.EXPList.Text == "7 200 XP")
            {
                this.CRInput.Text = "11";
                this.CRList.Text = "Challenge 11";
                this.EXPInput.Text = "7 200";
            }
            else if (this.EXPList.Text == "8 400 XP")
            {
                this.CRInput.Text = "12";
                this.CRList.Text = "Challenge 12";
                this.EXPInput.Text = "8 400";
            }
            else if (this.EXPList.Text == "10 000 XP")
            {
                this.CRInput.Text = "13";
                this.CRList.Text = "Challenge 13";
                this.EXPInput.Text = "10 000";
            }
            else if (this.EXPList.Text == "11 500 XP")
            {
                this.CRInput.Text = "14";
                this.CRList.Text = "Challenge 14";
                this.EXPInput.Text = "11 500";
            }
            else if (this.EXPList.Text == "13 000 XP")
            {
                this.CRInput.Text = "15";
                this.CRList.Text = "Challenge 15";
                this.EXPInput.Text = "13 000";
            }
            else if (this.EXPList.Text == "15 000 XP")
            {
                this.CRInput.Text = "16";
                this.CRList.Text = "Challenge 16";
                this.EXPInput.Text = "15 000";
            }
            else if (this.EXPList.Text == "18 000 XP")
            {
                this.CRInput.Text = "17";
                this.CRList.Text = "Challenge 17";
                this.EXPInput.Text = "18 000";
            }
            else if (this.EXPList.Text == "20 000 XP")
            {
                this.CRInput.Text = "18";
                this.CRList.Text = "Challenge 18";
                this.EXPInput.Text = "20 000";
            }
            else if (this.EXPList.Text == "22 000 XP")
            {
                this.CRInput.Text = "19";
                this.CRList.Text = "Challenge 19";
                this.EXPInput.Text = "22 000";
            }
            else if (this.EXPList.Text == "25 000 XP")
            {
                this.CRInput.Text = "20";
                this.CRList.Text = "Challenge 20";
                this.EXPInput.Text = "25 000";
            }
            else if (this.EXPList.Text == "33 000 XP")
            {
                this.CRInput.Text = "21";
                this.CRList.Text = "Challenge 21";
                this.EXPInput.Text = "33 000";
            }
            else if (this.EXPList.Text == "41 000 XP")
            {
                this.CRInput.Text = "22";
                this.CRList.Text = "Challenge 22";
                this.EXPInput.Text = "41 000";
            }
            else if (this.EXPList.Text == "50 000 XP")
            {
                this.CRInput.Text = "23";
                this.CRList.Text = "Challenge 23";
                this.EXPInput.Text = "50 000";
            }
            else if (this.EXPList.Text == "62 000 XP")
            {
                this.CRInput.Text = "24";
                this.CRList.Text = "Challenge 24";
                this.EXPInput.Text = "62 000";
            }
            else if (this.EXPList.Text == "155 000 XP")
            {
                this.CRInput.Text = "30";
                this.CRList.Text = "Challenge 30";
                this.EXPInput.Text = "155 000";
            }
        }

        private void DoneClick(object sender, System.EventArgs e)
        {
            this.experience = int.Parse(this.EXPInput.Text.Replace(" ",string.Empty));
            this.challenge = double.Parse(this.CRInput.Text);

            this.Close();
        }
    }
}

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
    public partial class AbilityForm : Form
    {
        public Abilities AllAbility;
        public bool Throws=false;
        public int ThrowStr = -10;
        public int ThrowDex = -10;
        public int ThrowCon = -10;
        public int ThrowInt = -10;
        public int ThrowWis = -10;
        public int ThrowChar = -10;
        public DataGridView Output;

        public AbilityForm(ref Abilities Input)
        {
            InitializeComponent();

            AllAbility = Input;
        }

        public void AddClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            AllAbility.AddAbility(this.NameInput.Text, this.DescriptionInput.Text);

            this.NameInput.Text = "";
            this.DescriptionInput.Text = "";
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            Output = this.StatsInput;

            if (this.NameInput.Text != "")
            {
                AllAbility.AddAbility(this.NameInput.Text, this.DescriptionInput.Text);
            }

            if (this.StatsInput.Rows.Count != 0)
            {
                Throws = true;
                DataGridViewRow ThrowRow = this.StatsInput.Rows[0];

                if (ThrowRow.Cells["Str"].Value != null)
                {
                    ThrowStr = Convert.ToInt16(ThrowRow.Cells["Str"].Value);
                }

                if (ThrowRow.Cells["Dex"].Value != null)
                {
                    ThrowDex = Convert.ToInt16(ThrowRow.Cells["Dex"].Value);
                }

                if (ThrowRow.Cells["Con"].Value != null)
                {
                    ThrowCon = Convert.ToInt16(ThrowRow.Cells["Con"].Value);
                }

                if (ThrowRow.Cells["Int"].Value != null)
                {
                    ThrowInt = Convert.ToInt16(ThrowRow.Cells["Int"].Value);
                }

                if (ThrowRow.Cells["Wis"].Value != null)
                {
                    ThrowWis = Convert.ToInt16(ThrowRow.Cells["Wis"].Value);
                }

                if (ThrowRow.Cells["Char"].Value != null)
                {
                    ThrowChar = Convert.ToInt16(ThrowRow.Cells["Char"].Value);
                }
            }

            this.Close();
        }
    }
}

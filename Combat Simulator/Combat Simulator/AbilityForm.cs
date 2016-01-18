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
        public DataGridView Output;

        public AbilityForm()
        {
            InitializeComponent();

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

            if (this.NameInput.Text != "")
            {
                AllAbility.AddAbility(this.NameInput.Text, this.DescriptionInput.Text);
            }
     
            this.Close();
        }
    }
}

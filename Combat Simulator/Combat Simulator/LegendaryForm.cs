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
    public partial class LegendaryForm : Form
    {
        Actions AllActions;
        public LegendaryForm(ref Actions input)
        {
            InitializeComponent();
            this.AllActions = input;

        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            LegendaryActions action = new LegendaryActions(this.NameInput.Text,this.InfoInput.Text, int.Parse(this.CostInput.Text));

            AllActions.AddLegendary(action);

            AllActions.LegendPoints = int.Parse(this.AmountInput.Text);

            this.Close();
        }

        public void AddClick(object sender, System.EventArgs e)
        {
            LegendaryActions action = new LegendaryActions(this.NameInput.Text, this.InfoInput.Text, int.Parse(this.CostInput.Text));

            AllActions.AddLegendary(action);

            AllActions.LegendPoints = int.Parse(this.AmountInput.Text);

            this.NameInput.Text = "";
            this.InfoInput.Text = "";
            this.CostInput.Text = "";
        }
    }
}

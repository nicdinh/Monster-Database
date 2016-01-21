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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void InsertAllyClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.

            //Database test = new Database();
            CreateMonster x = new CreateMonster();
            x.Show();

            //NewMonster window = new NewMonster(ref this.DataEnemies,test.AllCreatures[0]);
            //window.Show();
        }

        private void InsertEnemyClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            NewMonster test = new NewMonster(ref this.DataEnemies);
            test.Show();
        }

        private void StartClick(object sender, System.EventArgs e)
        {
            // Add event handler code here.

        }
    }
}

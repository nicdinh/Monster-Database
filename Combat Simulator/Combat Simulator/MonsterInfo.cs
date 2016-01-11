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
    public partial class MonsterInfo : Form
    {
        public MonsterInfo(Monster Input)
        {
            InitializeComponent(Input);
        }

        private void DoneClick(object sender, EventArgs e)
        {

        }
    }
}

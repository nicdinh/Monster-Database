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
    public partial class TypeForm : Form
    {
        public string Type;
        public string Alignment;
        public TypeForm(ref string type, ref string alignment)
        {
            InitializeComponent();

            this.Type = type;
            this.Alignment = alignment;
        }

        public void DoneClick(object sender, System.EventArgs e)
        {
            this.Type = this.TypeInput.Text;
            this.Alignment = this.AlignmentInput.Text;

            this.Close();
        }
    }
}

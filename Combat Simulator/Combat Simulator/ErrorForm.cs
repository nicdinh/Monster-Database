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
    public partial class ErrorForm : Form
    {
        public ErrorForm(Exception error, string message)
        {
            InitializeComponent();

            this.Title.Text = message;
            this.Input.Text = error.Message;
            this.Input.ReadOnly = true;
        }
    }
}

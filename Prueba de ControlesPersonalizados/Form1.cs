using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_ControlesPersonalizados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tbDarkTheme.Checked)
            {
                this.BackColor = Color.DimGray;
                DarkTheme.ForeColor = Color.White;
                DarkTheme.Visible= true;
                WhiteTheme.Visible= false;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                DarkTheme.Visible = false;
                WhiteTheme.ForeColor = Color.Black;
                WhiteTheme.Visible = true;
            }
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            picture2.Visible = true;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            picture3.Visible = true;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            picture4.Visible = true;
        }

        private void picture2_Click(object sender, EventArgs e)
        {

        }
    }
}

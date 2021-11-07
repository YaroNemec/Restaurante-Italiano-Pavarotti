using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Comensales
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (p3panel.Visible == true)
            {
                p3panel.Visible = false;
            }
            else { p3panel.Visible = true; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (p1panel.Visible == true)
            {
                p1panel.Visible = false;
            }
            else { p1panel.Visible = true; }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (p2panel.Visible == true)
            {
                p2panel.Visible = false;
            }
            else { p2panel.Visible = true; }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (p4panel.Visible == true)
            {
                p4panel.Visible = false;
            }
            else { p4panel.Visible = true; }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (p5panel.Visible == true)
            {
                p5panel.Visible = false;
            }
            else { p5panel.Visible = true; }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (p6panel.Visible == true)
            {
                p6panel.Visible = false;
            }
            else { p6panel.Visible = true; }
        }

    }
}

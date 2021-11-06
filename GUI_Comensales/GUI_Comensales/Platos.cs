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
    public partial class Platos : Form
    {
        public Platos()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            menu_button.BackColor = Color.Transparent;
            //menu_button.FlatAppearance.BorderColor = Color.Transparent;
        }
        private void label1_Click(object sender, EventArgs e)
        {
           Form1 principal = new Form1();
            principal.Show();
            this.Hide();
            //this.Dispose();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            MenuPlatos mp = new MenuPlatos();
            mp.Show();
            this.Hide();
            //this.Dispose();

        }
    }
}

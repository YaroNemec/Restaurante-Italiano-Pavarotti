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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Ordenar();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
           //salir
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Ordenar();
        }

        public void Ordenar()
        {

            int PaddingTopBtn = (Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Width / 4) / 2 - 82;
            Btn_Platos.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 16, PaddingTopBtn);
            Btn_Platos.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Width / 4);

            Btn_Postres.Location = new System.Drawing.Point(2 * Screen.PrimaryScreen.Bounds.Width / 16 + Screen.PrimaryScreen.Bounds.Width / 4, PaddingTopBtn);
            Btn_Postres.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Width / 4);

            Btn_Bebidas.Location = new System.Drawing.Point(3 * Screen.PrimaryScreen.Bounds.Width / 16 + 2 * Screen.PrimaryScreen.Bounds.Width / 4, PaddingTopBtn);
            Btn_Bebidas.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Width / 4);

        }

        private void Btn_Platos_Click(object sender, EventArgs e)
        {
            MenuPlatos mp = new MenuPlatos();
            mp.Show();
            this.Hide();
        }

        private void Btn_Postres_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Bebidas_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Platos p = new Platos();
            p.Show();
            this.Hide();
        }
    }
}

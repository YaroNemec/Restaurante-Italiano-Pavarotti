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


        public void Ordenar()
        {

            int PaddingTopBtn = (Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Width / 4) / 2 - 82;
            Btn_Platos.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 16, PaddingTopBtn);
            Btn_Platos.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Width / 4);

            Btn_Postres.Location = new System.Drawing.Point(2 * Screen.PrimaryScreen.Bounds.Width / 16 + Screen.PrimaryScreen.Bounds.Width / 4, PaddingTopBtn);
            Btn_Postres.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Width / 4);

            Btn_Bebidas.Location = new System.Drawing.Point(3 * Screen.PrimaryScreen.Bounds.Width / 16 + 2 * Screen.PrimaryScreen.Bounds.Width / 4, PaddingTopBtn);
            Btn_Bebidas.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Width / 4);

            label5.Location= label5.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 16+150, PaddingTopBtn + Screen.PrimaryScreen.Bounds.Width / 4);
            label6.Location = label6.Location = new System.Drawing.Point(3 * Screen.PrimaryScreen.Bounds.Width / 16 + 2 * Screen.PrimaryScreen.Bounds.Width / +150, PaddingTopBtn + Screen.PrimaryScreen.Bounds.Width / 4);
            label7.Location = label7.Location = new System.Drawing.Point(2 * Screen.PrimaryScreen.Bounds.Width / 16 + Screen.PrimaryScreen.Bounds.Width / 4+150, PaddingTopBtn + Screen.PrimaryScreen.Bounds.Width / 4);
        }

        private void Btn_Platos_Click(object sender, EventArgs e)
        {
            MenuPlatos mp = new MenuPlatos();
            mp.Show();
            this.Hide();
        }

        private void Btn_Postres_Click(object sender, EventArgs e)
        {
            MenuPostres mps = new MenuPostres();
            mps.Show();
            this.Hide();
        }

        private void Btn_Bebidas_Click(object sender, EventArgs e)
        {
            MenuBebidas mb = new MenuBebidas();
            mb.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Platos p = new Platos();
            p.Show();
            this.Hide();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.ShowDialog();

        }
    }
}

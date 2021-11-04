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
            //int screenx= Screen.PrimaryScreen.Bounds.Width;
            //int screeny = Screen.PrimaryScreen.Bounds.Height;
            //menu.Location = new System.Drawing.Point(0,barra.Height);
            //menu.Size = new System.Drawing.Size(screenx, screeny - 90);
        }

      
    }
}

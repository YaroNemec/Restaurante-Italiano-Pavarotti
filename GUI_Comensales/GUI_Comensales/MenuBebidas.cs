using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI_Comensales
{
    public partial class MenuBebidas : Form
    {
        MySqlConnection conexion = Connection.MDBConexion();
        public MenuBebidas()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Desglozar();
        }
        public void Desglozar()
        {
            string command = "Select imagen, nombrePlato, descripcion, precio from plato where idcategoria = 3";
            MySqlDataReader reader = Connection.Query(command, conexion);
            DG_bebidas.RowTemplate.Height = 120;
            while (reader.Read())
            {
                Image imagen = Image.FromFile(reader.GetString(0));
                int n = DG_bebidas.Rows.Add();
                
                DG_bebidas.Rows[n].Cells[0].Value = imagen;
                DG_bebidas.Rows[n].Cells[1].Value = reader.GetString(1);
                DG_bebidas.Rows[n].Cells[2].Value = reader.GetString(2);
                DG_bebidas.Rows[n].Cells[3].Value = reader.GetString(3);
                
               //yaro de mrda no sabias como poner las imagenes puto
               //Que raro que no hayan podido con PRoperties.Resouces.Nombres :U
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void anadir_bebida_Click(object sender, EventArgs e)
        {
            try
            {
                int precio = int.Parse(cant_bebidas.Text.ToString()) * int.Parse(DG_bebidas.CurrentRow.Cells[3].Value.ToString());
                int n = anadidos_dg.Rows.Add();
                anadidos_dg.Rows[n].Cells[0].Value = bebida.Text.ToString();
                anadidos_dg.Rows[n].Cells[1].Value = cant_bebidas.Text.ToString();
                anadidos_dg.Rows[n].Cells[2].Value = precio.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitar_bebida_Click(object sender, EventArgs e)
        {
            try
            {
                anadidos_dg.Rows.Remove(anadidos_dg.CurrentRow);
            }catch(Exception ex)
            { MessageBox.Show("Seleccione la bebida a cancelar de la lista de pedidos"); }
            
        }
        private void DG_platos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bebida.Text = DG_bebidas.CurrentRow.Cells[1].Value.ToString();

                precio_bebida.Text = DG_bebidas.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void siguiente_button_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_platos_Click(object sender, EventArgs e)
        {
            MenuPlatos mp = new MenuPlatos();
            mp.Show();
            this.Hide();
        }

        private void menu_postres_Click(object sender, EventArgs e)
        {
            MenuPostres mps = new MenuPostres();
            mps.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.ShowDialog();
        }
    }

}

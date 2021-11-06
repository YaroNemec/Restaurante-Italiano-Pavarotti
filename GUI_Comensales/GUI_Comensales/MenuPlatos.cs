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
    public partial class MenuPlatos : Form
    {
        MySqlConnection conexion = Connection.MDBConexion();
        public MenuPlatos()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Desglozar();
        }
        public void Desglozar()
        {
            string command = "Select imagen, nombrePlato, descripcion, precio from plato where idcategoria = 1";
            MySqlDataReader reader = Connection.Query(command, conexion);
            DG_platos.RowTemplate.Height = 120;
            while (reader.Read())
            {
                Image imagen = Image.FromFile(reader.GetString(0));
                int n = DG_platos.Rows.Add();
                
                DG_platos.Rows[n].Cells[0].Value = imagen;
                DG_platos.Rows[n].Cells[1].Value = reader.GetString(1);
                DG_platos.Rows[n].Cells[2].Value = reader.GetString(2);
                DG_platos.Rows[n].Cells[3].Value = reader.GetString(3);
                
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

        private void anadir_plato_Click(object sender, EventArgs e)
        {
            try
            {
                int precio = int.Parse(cant_platos.Text.ToString()) * int.Parse(DG_platos.CurrentRow.Cells[3].Value.ToString());
                int n = anadidos_dg.Rows.Add();
                anadidos_dg.Rows[n].Cells[0].Value = platillo.Text.ToString();
                anadidos_dg.Rows[n].Cells[1].Value = cant_platos.Text.ToString();
                anadidos_dg.Rows[n].Cells[2].Value = precio.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitar_plato_Click(object sender, EventArgs e)
        {
            anadidos_dg.Rows.Remove(anadidos_dg.CurrentRow);
        }
        private void DG_platos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                platillo.Text = DG_platos.CurrentRow.Cells[1].Value.ToString();

                precio_platillo.Text = DG_platos.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void siguiente_button_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MenuBebidas mb = new MenuBebidas();
            mb.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }

}

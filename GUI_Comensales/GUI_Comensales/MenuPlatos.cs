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
            Desglozar();
        }
        public void Desglozar()
        {
            string command = "Select imagen, nombrePlato, descripcion, precio from plato";
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

        private void DG_platos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI_Comensales
{
    class Connection
    {
        

            public static MySqlConnection MDBConexion()//Esta es una funcion estatica, de tipo MySqlConnection
            {
                string servidor = "localhost";
                string basedatos = "restaurantdb";
                string usuario = "root";
                string contraseña = "1234";
                string ingresar = "server=" + servidor + "; database=" + basedatos + "; uid=" + usuario + ";pwd=" + contraseña + "";
                try
                {
                    MySqlConnection conexion = new MySqlConnection(ingresar);
                    conexion.Open();
                    return conexion;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }

            public MySqlConnection ConectarUsuario(string user, string password)//Esta es una funcion estatica, de tipo MySqlConnection
            {
                string servidor = "localhost";
                string basedatos = "restaurantdb";
                string usuario = user;
                string contraseña = password;
                string ingresar = "server=" + servidor + "; database=" + basedatos + "; uid=" + usuario + ";pwd=" + contraseña + "";
                try
                {
                    MySqlConnection conexion = new MySqlConnection(ingresar);
                    conexion.Open();
                    return conexion;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
            public static MySqlDataReader Query(string comando, MySqlConnection coneccion)
            {
                MySqlDataReader reader;
                try
                {
                    MySqlCommand sql = new MySqlCommand(comando, coneccion);
                    reader = sql.ExecuteReader();
                    return reader;
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return null;
                }
            }
        
    }
}

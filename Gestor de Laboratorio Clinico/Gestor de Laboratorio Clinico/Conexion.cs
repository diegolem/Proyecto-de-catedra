using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//NC-1 More namespaces.  
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Gestor_de_Laboratorio_Clinico
{
    class Conexion
    {
        public static string con() {
            try
            {
                //Cadena de conexión a la base de datos
                const string connMysql = "DataSource=localhost; Database=computadoras; Uid=Usuario; Pwd=Password;";
                //Instrucción sql que realiza la consulta
                const string sql = @"select idEquipos from equipos where Marca = 'Gateway'";
                //Creo una instancia de la clase MySqlConnection y le asigno la cadena de conexión
                MySqlConnection myconn = new MySqlConnection(connMysql);
                //Creo la instancia Command y le asigno los dos parámetros necesarios para realizar la consulta
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                //Abro la conexión
                myconn.Open();
                //Ejecto la instrucción con el método de la clase MySqlCommand ExecuteScalar()
                int result = Convert.ToInt32(mycmd.ExecuteScalar());
                //Asigno el resultado a la caja de texto del proyecto
                //textBox1.Text = result.ToString();
                return result.ToString();
            }
            catch (MySqlException ex)
            {
                //Capturo el error en caso de haberlo
                return string.Format("Hubo un error al conectar: {0} ", ex.Message);
            }
            
        }
        
        }
    }


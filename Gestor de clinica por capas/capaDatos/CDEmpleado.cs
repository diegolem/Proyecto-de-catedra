using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class CDEmpleado //la clase tiene que ser publica
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;
        
        
        //Mando a llamar el procedimiento almacenado para inicar sesion en la base de datos
        public SqlDataReader iniciarSesion(String user, String pass) {
            SqlCommand comando = new SqlCommand("clinicas.SPIniciarSesion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@pass", pass);
            leer = comando.ExecuteReader();
            return leer;
        }


    }
}

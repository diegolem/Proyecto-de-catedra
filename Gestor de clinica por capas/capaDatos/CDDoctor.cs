using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class CDDoctor//la clase tiene que ser publica
    {

        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;

        //Iniciando mantenimiento para doctores
        public SqlDataReader insertarDoctor(String especialidad, String descripcion, String fk_empleado)
        {
            SqlCommand comando = new SqlCommand("insertarDoctor", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@especialidad", especialidad);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fk_idempleado", fk_empleado);
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}

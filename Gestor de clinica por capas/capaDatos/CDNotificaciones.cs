using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class CDNotificaciones
    {

        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader verNotificacion(string idEmpleado)
        {
            SqlCommand comando = new SqlCommand("clinicas.verNotificacion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_empleado", idEmpleado);
            leer = comando.ExecuteReader();
            return leer;
        }

        public SqlDataReader enviarNotificacion(string receptor, string emisor, string mensaje, string idReceptor)
        {
            SqlCommand comando = new SqlCommand("clinicas.enviarNotificacion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_receptor", idReceptor);
            comando.Parameters.AddWithValue("@receptor", receptor);
            comando.Parameters.AddWithValue("@emisor", emisor);
            comando.Parameters.AddWithValue("@mensaje", mensaje);
            leer = comando.ExecuteReader();
            return leer;
        }

        public SqlDataReader borrarNotificacion(int idNotificacion)
        {
            SqlCommand comando = new SqlCommand("clinicas.verNotificacion", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_notificacion", idNotificacion);
            leer = comando.ExecuteReader();
            return leer;
        }

    }
}

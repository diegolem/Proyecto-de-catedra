using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data.SqlClient;

namespace capaNegocios
{
    public class CNNotificacion
    {
        //Encapsular variables
        private CDNotificaciones objDato = new CDNotificaciones();//instancia a la capa datos de empleados
        //variables

        int id;
        string emisor;
        string receptor;
        string fk_emisor;
        string mensaje;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Emisor1
        {
            get
            {
                return emisor;
            }

            set
            {
                emisor = value;
            }
        }
        public string Receptor1
        {
            get
            {
                return receptor;
            }

            set
            {
                receptor = value;
            }
        }
        public string Fk_emisor1
        {
            get
            {
                return fk_emisor;
            }

            set
            {
                fk_emisor = value;
            }
        }

        public string Mensaje1
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }







        //constructor
        public CNNotificacion() { }
        //funciones o metodos
        public List<object> verNotificacion()
        {

            List<object> verNotificacion;
            verNotificacion = objDato.verNotificacion(fk_emisor);

            return verNotificacion;
        }

        public SqlDataReader enviarNotificacion()
        {
            SqlDataReader enviarNotificacion;
            enviarNotificacion = objDato.enviarNotificacion(Receptor1,Emisor1,Mensaje1,Receptor1);
            return enviarNotificacion;
        }

        public SqlDataReader borrarNotificacion()
        {
            SqlDataReader borrarNotificacion;
            borrarNotificacion = objDato.borrarNotificacion(Id);
            return borrarNotificacion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data.SqlClient;
using System.Data;

namespace capaNegocios
{
    public class CNDoctor : CNEmpleado //la clase tiene que ser publica, y hereda los datos de CNEmpleados
    {
        //Encapsular variables
        private CDDoctor objDato = new CDDoctor();
        //variables
        private string especialidad;
        private string descripcion;
        private string fk_empleado;

        public string Especialidad
        {
            get
            {
                return especialidad;
            }

            set
            {
                especialidad = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
        public string Fk_empleado1
        {
            get
            {
                return fk_empleado;
            }

            set
            {
                fk_empleado = value;
            }
        }
    }
}
 








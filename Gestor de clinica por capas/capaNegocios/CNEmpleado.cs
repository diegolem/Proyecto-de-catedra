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
    public class CNEmpleado//la clase tiene que ser publica
    {
        //Encapsular variables
        private CDEmpleado objDato = new CDEmpleado();//instancia a la capa datos de empleados
        //variables
        private string id;
        private String _Nombre;
        private String _Apellido;
        private String _Direccion;
        private String _Telefono;
        private String _Dui;
        private String _Genero;
        private String _usuario;
        private String _pass;
        private String _Fk_IDClinica;
        private String _esquema;

        //Metdos GET y SET --> para manejo de variables
        public string Id { get => id; set => id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Dui { get => _Dui; set => _Dui = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Usuario {
            get => _usuario;
            set
            {
                if (value == "USUARIO")
                {
                    _usuario = "No ha ingresado usuario";
                }
                else
                {
                    _usuario = value;
                }
            }
        }
        public string Pass {
            get => _pass;
            set
            {
                if (value == "CONTRASEÑA")
                {
                    _pass = "No ha ingresado una contraseña";
                }
                else
                {
                    _pass= value;
                }
            }
        }
        public string Fk_IDClinica { get => _Fk_IDClinica; set => _Fk_IDClinica = value; }
        public string Esquema { get => _esquema; set => _esquema = value; }


        //constructor
        public CNEmpleado() { }
        //funciones o metodos
        public SqlDataReader IniciarSesion() {
            SqlDataReader Logear;
            Logear = objDato.iniciarSesion(Usuario, Pass);
            return Logear;
        }
        


    }
}

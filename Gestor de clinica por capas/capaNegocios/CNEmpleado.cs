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
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        
        public string Direccion {
            get { return Direccion; } 
                set { Direccion = value;  }
            }
        public string Telefono1
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }
        public string Dui
        {
            get
            {
                return _Dui;
            }

            set
            {
                _Dui = value;
            }
        }
        public string Genero1
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }
        public string Usuario1
        {
            get
            {
                return _usuario;
            }

            set
            {
                if (value == "USUARIO")
                {
                    Usuario1 = "No ha ingresado usuario";
                }
                else
                {
                    Usuario1 = value;
                }
            }
        }
       
        public string Pass {
            get
            {
                return Pass;
            }
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
        public string Fk_IDClinica1
        {
            get
            {
                return _Fk_IDClinica;
            }

            set
            {
                _Fk_IDClinica = value;
            }
        }
        public string Esquema1
        {
            get
            {
                return _esquema;
            }

            set
            {
                _esquema = value;
            }
        }







        //constructor
        public CNEmpleado() { }
        //funciones o metodos
        public SqlDataReader IniciarSesion() {
            SqlDataReader Logear;
            Logear = objDato.iniciarSesion(Usuario1, Pass);
            return Logear;
        }
        


    }
}

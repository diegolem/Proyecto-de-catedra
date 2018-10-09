﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;

namespace capaPresentacion
{
    public partial class MenuVertical : Form
    {
        //variables Globales para el control de menuprincipal recuerden ponerle :Menuvertical despues del nombre de la clase para que su clase herede las variables

            /*con estas variables van a poder acceder a caracteristicas del menu principal*/
        public static string usuarioSesion;//pueden usar esta variable para saber el id del usuario que se ha logeado, no le asignen valores por que se le asigna desde el login
        public string nombreSesion;
        public string rolSesion;
        public string clinicasesion;
        public string errores;// con esta variable pueden poner errores en la barra de estado del menu
        
        Timer t = new Timer();
        public MenuVertical()
        {
            InitializeComponent();

            //me quedé aqui para mandar a llamar las variables de sesion
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuPrincipal.Width == 250)
            {
                menuPrincipal.Width = 80;
            }
            else
            {
                menuPrincipal.Width = 250;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuOpciones.Width == 250)
            {
                menuOpciones.Width = 0;
            }
            else
            {
                menuOpciones.Width = 250;
            }
            btnNotificaciones_Click(null, e);
        }

        private void MenuVertical_Load(object sender, EventArgs e)
        {
            menuOpciones.Width = 0;
            menuPrincipal.Width = 80;

            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            btnTemas.BackColor = Color.FromArgb(41, 66, 91);
            btnNotificaciones.BackColor = Color.FromArgb(50, 81, 112);
            panelContTemas.Visible = false;
            contNotificicaciones.Visible = true;

            listNotificaciones.Items.Clear();
            //el siguiente bucle comentado puede ser reutilizado
            //creo un objeto de tipo CNNotificacion(clase que se crea en la capa de negocios)
            CNNotificacion objNotificacion = new CNNotificacion();
            //Creo un objeto tipo lista, donde almacenaré lo que me retorna el procedimiento
            List<object> verNotificacion = new List<object>();
            //asigno variables al objeto (getters y setters creados en la clase de negocios) esto servirá para saber de quien es la notificacion
            objNotificacion.Fk_emisor = MenuVertical.usuarioSesion;
            //mando a llamar el procedimiento y lo almaceno en verNotificacion(el que cree arriba)
            verNotificacion = objNotificacion.verNotificacion();
            try
            {
                verNotificacion.Reverse(); //para invertir el orden, ya que las ultimas notificaciones deben mostrarse de primero en la lista
                foreach (object[] datos in verNotificacion)
                {//lleno la lista
                    listNotificaciones.Items.Add("[" + datos[1].ToString().Replace(" ", "") + "]--" + datos[3].ToString());//construllo el formato de la notificacion
                }
            }
            catch (Exception ex) {

            }

            
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            panelContTemas.Visible = true;
            contNotificicaciones.Visible = false;
            btnTemas.BackColor = Color.FromArgb(50, 81, 112);
            btnNotificaciones.BackColor = Color.FromArgb(41, 66, 91);
        }

        private void t_Tick(Object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;
            string fecha = "";
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                if ((hh - 12) < 10)
                {
                    time += "0" + (hh - 12);
                }
                else
                {
                    time += (hh - 12);
                }
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            if (hh < 12)
            {
                time += "  AM";
            }
            else if (hh == 12)
            {
                time += "  M";
            }
            else
            {
                time += "  PM";
            }


            if (dia < 10)
            {
                fecha += "0" + dia + "/";
            }
            else
            {
                fecha += dia + "/";
            }

            if (mes < 10)
            {
                fecha += "0" + mes + "/";
            }
            else
            {
                fecha += mes + "/";
            }

            fecha += anio;
            reloj.Text = time;
            lblFecha.Text = fecha;



        }

        private void btnClinica_Click(object sender, EventArgs e)
        {
            
            //statusLabel.Text = Conexion.con();
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            if (PanelBotonLaboratorio.Height == 210)
            {
                PanelBotonLaboratorio.Height= 50;
            }
            else
            {
                PanelBotonLaboratorio.Height = 210;
                menuPrincipal.Width = 250;
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOdontologia_Click(object sender, EventArgs e)
        {

        }
    }
}
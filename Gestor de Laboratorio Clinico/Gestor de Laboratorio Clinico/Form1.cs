using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Laboratorio_Clinico
{
    public partial class MenuVertical : Form
    {
        Timer t = new Timer();
        public MenuVertical()
        {
            InitializeComponent();
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

        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            

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
            if (hh < 10)
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
            
            statusLabel.Text = Conexion.con();
        }
    }
}

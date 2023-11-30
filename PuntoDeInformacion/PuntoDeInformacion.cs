using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace PuntoDeInformacion
{
    public partial class PuntoDeInformacion : Form
    {
        // Variables
        private IconButton actualBtn;
        private Panel izqBordeBtn;
        private Form hijoActual;

        // Constructor
        public PuntoDeInformacion()
        {
            InitializeComponent();
            izqBordeBtn = new Panel();
            izqBordeBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(izqBordeBtn);

            // Eliminar la barra superior
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            // Si quiero mostrar la barra de tareas...
            // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static System.Drawing.Color azulOscuro = System.Drawing.Color.FromArgb(35, 108, 155);
            public static System.Drawing.Color azulMedio = System.Drawing.Color.FromArgb(84, 165, 220);
            public static System.Drawing.Color amarillo = System.Drawing.Color.FromArgb(255, 205, 0);
            public static System.Drawing.Color azulClaro = System.Drawing.Color.FromArgb(144, 204, 228);
            public static System.Drawing.Color rojo = System.Drawing.Color.FromArgb(234, 86, 112);
        }

        // Métodos
        private void ActivarBoton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DesactivarBoton();
                // Botón
                actualBtn = (IconButton)senderBtn;
                actualBtn.BackColor = RGBColors.azulClaro;
                actualBtn.IconColor = RGBColors.azulOscuro;
                actualBtn.ForeColor = RGBColors.azulOscuro;

                // Borde
                izqBordeBtn.BackColor = RGBColors.amarillo;
                izqBordeBtn.Location = new Point(0, actualBtn.Location.Y);
                izqBordeBtn.Visible = true;
                izqBordeBtn.BringToFront();
            }
        }

        private void DesactivarBoton()
        {
            if(actualBtn != null)
            {
                actualBtn.BackColor = RGBColors.azulOscuro;
                actualBtn.ForeColor = System.Drawing.Color.Gainsboro;
                actualBtn.IconColor = RGBColors.azulMedio;
            }
        }

        private void AbrirFormHijo(Form childForm)
        {
            if(hijoActual != null)
            {
                hijoActual.Close();
            }
            hijoActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMostrar.Controls.Add(childForm);
            panelMostrar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ButtonEquipo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Equipo());
        }

        private void ButtonEstudios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Estudios());
        }

        private void ButtonHorarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Horarios());
        }

        private void ButtonPlanos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Planos());
        }


        private void ButtonAparcamiento_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Aparcamiento());
        }

        private void ButtonContacto_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Contacto());
        }

        private void ButtonNormativa_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new Normativa());
        }
        private void ButtonInicio_Click(object sender, EventArgs e)
        {
            hijoActual.Close();
            Reiniciar();
        }

        private void Reiniciar()
        {
            DesactivarBoton();
            izqBordeBtn.Visible = false;
        }

        // Para arrastrar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lParam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ButtonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cescristorey.com");
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            izqBordeBtn.Visible = false;
            AbrirFormHijo(new AdminMenu());
        }

       
    }
}

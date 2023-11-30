using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeInformacion
{
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {

            // Comprobamos que todos los campos estén llenos:
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxEmail.Text) ||
                string.IsNullOrEmpty(textBoxAsunto.Text) || string.IsNullOrEmpty(richTextBoxMensaje.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos para enviar tu mensaje.", "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Configuración del servidor SMTP
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("sugerencias@cescristorey.com", "");
            //guillermoloz.alumn@cescristorey.com
            // Mensaje de correo electrónico
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("sugerencias@cescristorey.com");
            mailMessage.To.Add("sugerencias@cescristorey.com");
            mailMessage.Subject = textBoxAsunto.Text;
            mailMessage.Body = "Nombre: " + textBoxNombre.Text + Environment.NewLine +
                               "Email: " + textBoxEmail.Text + Environment.NewLine +
                               "Mensaje: " + richTextBoxMensaje.Text;
            mailMessage.SubjectEncoding = Encoding.UTF8;
            mailMessage.BodyEncoding = Encoding.UTF8;

            // Utilizamos la clase SmtpClient de .NET:
            smtpClient.Send(mailMessage);


            // Finalmente, limpiamos los campos del formulario:
            textBoxNombre.Text = "";
            textBoxEmail.Text = "";
            textBoxAsunto.Text = "";
            richTextBoxMensaje.Text = "";

            
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PuntoDeInformacion
{
    public partial class AdminMenu : Form
    {
        public class AportacionAlumno
        {
            public string Nombre { get; set; }
            public string Comentario { get; set; }
            public AportacionAlumno(string nombre, string comentario)
            {
                Nombre = nombre;
                Comentario = comentario;
            }
        }

        public AdminMenu()
        {

            InitializeComponent();
            ocultar();


        }

        private void ocultar()
        {
            dataGridViewTestimonios.Hide();
            buttonGuardar.Hide();
            labelTexto.Hide();
            labelModo.Hide();
        }

        private void mostrar()
        {
            dataGridViewTestimonios.Visible = true;
            buttonGuardar.Visible = true;
            labelTexto.Visible = true;
            labelModo.Visible = true;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            if (textBoxUsuario.Text.ToString().ToLower() == "admin" && textBoxPassword.Text.ToString().ToLower() == "admin")
            {
                textBoxUsuario.Text = "";
                textBoxPassword.Text = "";
                labelUser.Hide();
                labelPassword.Hide();
                ButtonLogin.Hide();
                textBoxUsuario.Hide();
                textBoxPassword.Hide();

                string json = File.ReadAllText("aportaciones.json");
                List<AportacionAlumno> listaAportaciones = JsonConvert.DeserializeObject<List<AportacionAlumno>>(json);

                dataGridViewTestimonios.DataSource = listaAportaciones;
                dataGridViewTestimonios.Columns[0].HeaderText = "Nombre";
                dataGridViewTestimonios.Columns[1].HeaderText = "Comentario";

                mostrar();
            }
            else
            {
                MessageBox.Show("Los datos introducidos no son correctos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            List<AportacionAlumno> listaAportaciones = dataGridViewTestimonios.DataSource as List<AportacionAlumno>;
            string json = JsonConvert.SerializeObject(listaAportaciones);
            File.WriteAllText("aportaciones.json", json);
            MessageBox.Show("Los cambios se han guardado correctamente.", "Cambios guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

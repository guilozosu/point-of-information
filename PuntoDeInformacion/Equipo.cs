using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeInformacion
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();

            // Creamos un array de rutas de imágenes de personas
            string[] imagePaths = new string[]
            {
                "C:\\Users\\dieef\\source\\repos\\PuntoDeInformacion\\PuntoDeInformacion\\Resources\\anonimo.png",
            };

            // Creamos un array de nombres de personas
            string[] names = new string[]
            {
                "Directora: Dña. M. Ángeles Martínez-Rey Molina",
                "Jefe de estudios: D. Jaime Matas Bustos",
                "Secretaría: Dña. Eva Maldonado Blanes",
                "Economía: Hna. Francisca Ramos Sánchez",
                "Orientador: D. Luis Pablo Hernández López",
                "Consejería: D. Federico",
                "1º de Bachillerato A: D. Juan Manuel Garrido Huete",
                "1º de Bachillerato B: Dña. Belén Matas Bustos",
                "2º de Bachillerato A: Dña. Mª Esther Hernández Carmona",
                "2º de Bachillerato B: Dña. Ana Belén Ramírez Rodríguez",
                "1º de CFGS EI: D. Luis Pablo Hernández López",
                "2º de CFGS EI: Dña. Rosario Gutiérrez Molina",
                "1º de CFGS DAM: D. Jaime Matas Bustos",
                "2º de CFGS DAM: D. Luis Serrano Donaire",
                "1º de CFGS IS: Dña. Elena López Molina",
                "1º de CFGS IS: Dña. Elisa Velasco Guerrero",

            };

            // Centra el PictureBox y el Label horizontalmente
            int centerX = this.ClientSize.Width / 2;
            int pictureBoxWidth = 100;
            int nameLabelWidth = 200;
            int pictureBoxX = centerX - pictureBoxWidth / 2;
            int nameLabelX = centerX - nameLabelWidth / 2;

            // Define la distancia desde el borde superior
            int margin = 70;

            // Crea una variable para hacer seguimiento de la posición vertical de los controles
            int top = margin;

            // Crea una serie de PictureBox y Label para cada persona
            for (int i = 0; i < names.Length; i++)
            {
                // Crea un PictureBox y ajusta su ubicación y tamaño
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePaths[0]);
                pictureBox.Anchor = AnchorStyles.Top;
                pictureBox.Location = new Point(pictureBoxX, top);
                pictureBox.Size = new Size(100, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pictureBox);

                // Crea un Label para el nombre y ajusta su ubicación y tamaño
                Label nameLabel = new Label();
                nameLabel.Text = names[i];
                nameLabel.Anchor = AnchorStyles.Top;
                nameLabel.Location = new Point(nameLabelX, top + 110);
                nameLabel.Size = new Size(nameLabelWidth, 50); // Ajusta el alto del Label a 50
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                nameLabel.AutoSize = false; // Desactiva el ajuste automático del tamaño
                this.Controls.Add(nameLabel);

                // Aumenta la posición vertical para la siguiente persona
                top += 170; // Ajusta la distancia vertical entre los controles a 170
            }

        }
    }
}

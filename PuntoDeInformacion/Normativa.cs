using Microsoft.Ajax.Utilities.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Normativa : Form
    {
        public Normativa()
        {
            InitializeComponent();

            // Ruta del archivo PDF a mostrar
            string normativaPath = "C:\\Users\\dieef\\source\\repos\\PuntoDeInformacion\\PuntoDeInformacion\\Resources\\Normas Convivencia 22-23.pdf";
        
            // Abro el archivo PDF en el control webBrowser
            webBrowserNormativa.Navigate(@normativaPath);
        }
    }
}

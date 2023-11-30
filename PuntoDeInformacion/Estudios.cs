using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using static PuntoDeInformacion.AdminMenu;

namespace PuntoDeInformacion
{
    public partial class Estudios : Form
    {
        public Estudios()
        {
            string[] estudios = new string[]
            {
                "Bachillerato: Itinerario Biosanitario y Ciencias de la Tierra",
                "Bachillerato: Itinerario Humanidades y Ciencias Sociales",
                "Bachillerato: Itinerario Científico-Técnico",
                "CFGS: Educación Infantil",
                "CFGS: Comercio Internacional",
                "CFGS: Desarrollo de Aplicaciones Multiplataforma"
            };

            InitializeComponent();

            mostrarTestimonios();
            comboBoxEstudios.Text = "Seleccione alguno de los estudios disponibles...";
            comboBoxEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstudios.Items.AddRange(estudios);



        }

        private void mostrarTestimonios()
        {
            string json = File.ReadAllText("aportaciones.json");
            List<AportacionAlumno> listaAportaciones = JsonConvert.DeserializeObject<List<AportacionAlumno>>(json);

            labelTestimonio1.Text = "\"" + listaAportaciones[0].Comentario + "\"" + " \n\t\t(" + listaAportaciones[0].Nombre + ")";

            labelTestimonio2.Text = "\"" + listaAportaciones[1].Comentario + "\"" + " \n\t\t(" + listaAportaciones[1].Nombre + ")";

            labelTestimonio3.Text = "\"" + listaAportaciones[2].Comentario + "\"" + " \n\t\t(" + listaAportaciones[2].Nombre + ")";

        }

        private void ocultarTestimonios()
        {
            labelTestimonio1.Hide();
            labelTestimonio2.Hide();
            labelTestimonio3.Hide();
        }

        private void comboBoxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Antes, ocultamos los testimonios
            ocultarTestimonios();

            // Primero, ocultamos todos los paneles
            panelEstudioBio.Visible = false;

            // Después, mostramos el panel correspondiente a la opción seleccionada
            switch (comboBoxEstudios.SelectedIndex)
            {
                case 0:
                    // Bachillerato Ciencias
                    panelEstudioBio.Visible = true;
                    richTextBoxInfo.Text = "Uno de los ámbitos de conocimiento que podrás abordar, escogiendo las materias adecuadas, es el de las Ciencias de la Salud o Biosanitarias.\n\n";
                    richTextBoxInfo.AppendText("Cursar materias como biología, química y, cómo no, otras áreas de ciencias como, las matemáticas, la física y las ciencias ambientales, te permitirán encaminarte al fascinante mundo de las áreas biosanitarias tanto en el ámbito universitario como en los ciclos formativos de grado superior. En la Universidad podrás realizar estudios de grado como: Biología, Biotecnología, Bioquímica, Bioinformática, Biología Humana, Biología Sanitaria, Biomedicina Básica y Experimental, Ciencia y Producción Animal, Ciencia y Tecnología de los Alimentos, Ciencias Biomédicas, Ciencias de la Actividad Física y del Deporte, Enfermería, Farmacia, Fisioterapia, Logopedia, Medicina, Nutrición Humana y Dietética, Odontología, Óptica y Optometría, Óptica, Optometría y Audiología, Podología, Psicología, Terapia Ocupacional, Veterinaria, Ciencias de la Actividad Física y del Deporte…\n\n");
                    richTextBoxInfo.AppendText("Dentro de los Ciclos Formativos de Grado Superior(CFGS) te dará acceso a poder solicitar entre otras las siguientes especialidades de la familia de la Sanidad: Audiología Protésica, Radioterapia y Dosimetría, Laboratorio Clínico y Biomédico, Diagnóstico y Medicina Nuclear, Higiene Bucodental, Documentación y Administración Sanitarias, Anatomía Patológica y Citodiagnóstico, Prótesis Dentales, Ortoprótesis y Productos de Apoyo, Salud ambiental, Dietética, Ortoprotésica.Y, por supuesto, podrás acceder a otras familias profesionales.\n\n");
                    richTextBoxInfo.AppendText("Son muchos los campos de formación en los que te puedes adentrar pero es más bonito aún formarse en este interesante y desconocido mundo, las ciencias asociadas a los diferentes ámbitos biosanitarias y de promoción de la salud.\n\n");
                    richTextBoxInfo.AppendText("Si tienes inquietudes por este ámbito de conocimiento, cuando te incorpores al bachillerato no dudes preguntar al Equipo Directivo, al Servicio de Orientación profesorado y al Profesorado para que tu elección de materias sea la más adecuada y te encamine hacia el futuro que tú quieres.\n\n");
                    richTextBoxInfo.AppendText(
                                                "1º Curso\n\n" +
                                                "- Materias Generales de Bloque:\n" +
                                                " · Filosofía\n" +
                                                " · Lengua Castellana y Literatura I\n" +
                                                " · Primera Lengua Extranjera I\n" +
                                                " · Matemáticas I\n\n" +
                                                "- Materias de Opción Bloque:\n" +
                                                " · Biología y Geología\n" +
                                                " · Dibujo Técnico I\n" +
                                                " · Física y Química\n\n" +

                                                "2º Curso\n\n" +
                                                "- Materias Generales de Bloque:\n" +
                                                " · Historia de España\n" +
                                                " · Lengua Castellana y Literatura II\n" +
                                                " · Primera Lengua Extranjera II\n" +
                                                " · Matemáticas II\n\n" +
                                                "- Materias de Opción Bloque:\n" +
                                                " · Biología\n" +
                                                " · Dibujo Técnico II\n" +
                                                " · Física\n" +
                                                " · Geología\n" +
                                                " · Química\n"
                                            );
                    break;
                case 1:
                    // Bachillerato Humanidades y CCSS
                    panelEstudioBio.Visible = true;
                    richTextBoxInfo.Text = "";
                    richTextBoxInfo.AppendText(
                                                "Las asignaturas del bachillerato LOMCE, se estructuran de la siguiente forma:\r\n" +
                                                "- Asignaturas troncales: estas asignaturas dan una formación general al alumnado. Algunas de ellas son obligatorias y algunas varían en función de la modalidad de bachillerato.\r\n" +
                                                "- Asignaturas específicas: son asignaturas para poder profundizar en la modalidad de bachillerato escogida. Los centros y las administraciones educativas pueden fijar su oferta.\r\n" +
                                                "- Asignaturas de libre configuración: en este tipo de asignaturas se incluyen las lenguas cooficiales (en las comunidades autónomas que las haya) que puede tener un carácter obligatorio. Además, se incluyen también asignaturas específicas, asignaturas de ampliación de contenidos u otras asignaturas a determinar por las administraciones educativas.\r\n" +
                                                "Para obtener el título de bachillerato, deberás superar todas las asignaturas.\r\n" +
                                                "Si lo que quieres es acceder a unos estudios universitarios, tendrás que superar una prueba específica de acceso a la universidad.\n\n" + 

                                                "1º Curso\n\n" +
                                                "- Materias Generales de Bloque:\n" +
                                                " · Filosofía\n" +
                                                " · Lengua Castellana y Literatura I\n" +
                                                " · Primera Lengua Extranjera I\n" +
                                                " · Latín I (itinerario humanidades)\n" +
                                                " · Matemáticas Aplicadas a las Ciencias Sociales I (itinerario CCSS)\n\n" +
                                                "- Materias de Opción Bloque:\n" +
                                                " · Economía\n" +
                                                " · Griego I\n" +
                                                " · Historia del Mundo Contemporáneo\n" +
                                                " · Literatura Universal\n\n" +

                                                "2º Curso\n\n" +
                                                "- Materias Generales de Bloque:\n" +
                                                " · Historia de España\n" +
                                                " · Lengua Castellana y Literatura II\n" +
                                                " · Primera Lengua Extranjera II\n" +
                                                " · Latín II (para humanidades)\n" +
                                                " · Matemáticas Aplicadas a las Ciencias Sociales II (para CCSS)\n\n" +
                                                "- Materias de Opción Bloque:\n" +
                                                " · Economía de la Empresa\n" +
                                                " · Geografía\n" +
                                                " · Griego II\n" +
                                                " · Historia del Arte\n" +
                                                " · Historia de la Filosofía\n"
                                            );
                    break;
                case 2:
                    // Científico técnico
                    panelEstudioBio.Visible = true;
                    richTextBoxInfo.Text = "La elección del Bachillerato, suele ser para los estudiantes una de las primeras decisiones importantes que tendrán que tomar a lo largo de su vida. Por ello, una de las cosas que debemos  tener en cuenta es que nuestra elección marcará nuestras opciones a la hora de elegir una carrera.\n\n";
                    richTextBoxInfo.AppendText("Perfil del estudiante: alumnos con interés por áreas como matemáticas, física, informática o tecnología. Tienen gran capacidad de razonamiento, observación, concentración, análisis y experimentación. Tienden a ser personas críticas, curiosas, estudiosas.El Bachillerato de Ciencias y Tecnología es una opción orientada a aquellos alumnos con intereses por estudiar carreras relacionadas con el mundo tecnológico. Además es un Bachillerato recomendado para aquellos alumnos que, pensando en un futuro empresarial o relacionado con la economía, ven en el campo de la tecnología un negocio de futuro.\n\n");
                    richTextBoxInfo.AppendText("Gracias a la oferta de materias de modalidad y optativas, los alumnos desde este bachillerato pueden especializarse en la rama de CC e Ingeniería en la que desarrollan las competencias y adquieren los conocimientos técnicos para el acceso a cualquier Ciclo Formativo relacionado con la Tecnología o Grado Universitario de Ciencias, Ingeniería o Arquitectura.\n\n");
                    richTextBoxInfo.AppendText(
                                                "1º Curso\n\n" +
                                                "- Materias Generales de Bloque:\n" +
                                                " · Filosofía\n" +
                                                " · Lengua Castellana y Literatura I\n" +
                                                " · Primera Lengua Extranjera I\n" +
                                                " · Matemáticas I\n\n" +
                                                "- Materias de Opción Bloque:\n" +
                                                " · Biología y Geología\n" +
                                                " · Dibujo Técnico I\n" +
                                                " · Física y Química\n" +
                                                " · Tecnología Industrial I\n" +
                                                " · Ciencias de la Tierra y medioambientales\n\n" +

                                                "2º Curso\n\n" +
                                                "- Materias Generales de Bloque:\n" +
                                                " · Historia de España\n" +
                                                " · Lengua Castellana y Literatura II\n" +
                                                " · Primera Lengua Extranjera II\n" +
                                                " · Matemáticas II\n\n" +
                                                "- Materias de Opción Bloque:\n" +
                                                " · Biología\n" +
                                                " · Dibujo Técnico II\n" +
                                                " · Física\n" +
                                                " · Geología\n" +
                                                " · Química\n" +
                                                " · Electrotecnia\n" +
                                                " · Tecnología industrial II\n"
                                            );
                    break;
                case 3:
                    // Educación infantil
                    panelEstudioBio.Visible = true;
                    richTextBoxInfo.Text = "Estudiar Educación Infantil en el C.E.S Cristo Rey, es aprender a trabajar con los niños,  conociendo como aprenden y cuál es la mejor manera de enseñarles, es conocer los métodos y técnicas educativas mas actuales, es saber cómo  generar entornos seguros y estimulantes para ellos. En definitiva, es prepararse para un futuro profesional ilusionante, que  permita participar en la formación de una sociedad mejorada, teniendo como pilar a la INFANCIA.\n\n";
                    richTextBoxInfo.AppendText(
                                                "¿QUÉ VOY A APRENDER A HACER?\r\n\n" +

                                                "Diseñar, aplicar y evaluar proyectos educativos para primer ciclo de educación infantil.\r\n" +
                                                "Este profesional será capaz de:\r\n" +
                                                "- Programar, diseñar y llevar a cabo actividades de intervención educativa y de atención social con la infancia y sus familias.\r\n" +
                                                "- Utilizar recursos y procedimientos para dar respuesta a las necesidades de los niños, niñas y familias que requieran la participación de otros profesionales o servicios.\r\n" +
                                                "- Actuar ante contingencias, transmitiendo seguridad y confianza.\r\n" +
                                                "- Evaluar el proceso de intervención y los resultados obtenidos, gestionando la documentación asociada y trasmitiendo la información.\r\n" +
                                                "- Mantener actualizados los conocimientos científicos y técnicos relativos a su actividad profesional, utilizando los recursos existentes para el aprendizaje a lo largo de la vida.\r\n" +
                                                "- Mantener relaciones fluidas con los niños y niñas y sus familias, miembros del grupo en el que se esté integrado y otros profesionales, mostrando habilidades sociales, capacidad de gestión de la diversidad cultural y aportando soluciones a conflictos que se presenten.\r\n\n" +
                                                "Estas enseñanzas incluyen los conocimientos necesarios para:\r\n" +
                                                "- Llevar a cabo las actividades de nivel básico de prevención de riesgos laborales.\r\n" +
                                                "- Poder obtener el carné de manipulador de alimentos.\r\n\r\n" +

                                                
                                                "PLAN DE FORMACIÓN\n\n" +

                                                "1º Curso\n\n" +
                                                " · Didáctica de la educación infantil\n" +
                                                " · Autonomía personal y salud infantil\n" +
                                                " · Expresión y comunicación\n" +
                                                " · Desarrollo cognitivo y motor\n" +
                                                " · Formación y orientación laboral\n" +
                                                " · Libre Configuración (Inglés y/o Informática Aplicada)\n\n" +

                                                "2º Curso\n\n" +
                                                " · El juego infantil y su metodología\n" +
                                                " · Desarrollo socio afectivo\n" +
                                                " · Habilidades sociales\n" +
                                                " · Intervención con familias y atención a menores en riesgo social\n" +
                                                " · Primeros auxilios\n" +
                                                " · Empresa e iniciativa emprendedora\n\n" + 


                                                "AL FINALIZAR MIS ESTUDIOS, ¿QUÉ PUEDO HACER?\n\n" +

                                                "· Trabajar\r\n" +
                                                "- En el sector de la educación formal y no formal y en el sector de los servicios sociales de atención a la infancia.\r\n\n" +

                                                "· Seguir estudiando\r\n" +
                                                "- Cursos de especialización profesional.\r\n" +
                                                "- Otro Ciclo de Formación Profesional de Grado Superior con la posibilidad de establecer convalidaciones de módulos profesionales de acuerdo a la normativa vigente.\r\n" +
                                                "- Enseñanzas Universitarias con la posibilidad de establecer convalidaciones de acuerdo con la normativa vigente.\n\n"

                                                );
                    break;
                case 4:
                    // Comercio internacional
                    panelEstudioBio.Visible = true;
                    richTextBoxInfo.Text =
                                                "¿QUÉ VOY A APRENDER A HACER?\r\n\n" + 

                                                "- Tomar decisiones sobre la entrada de los productos de una empresa en el mercado exterior, seleccionando las políticas de producto, precio, comunicación y distribución más adecuadas para la entrada en dichos mercados.\r\n" +
                                                "- Elaborar un plan de marketing, seleccionando la información de base o “briefing” de productos y analizando las relaciones entre las distintas variables que intervienen en el marketing mix internacional para la entrada en mercados exteriores.\r\n" +
                                                "- Identificar y contactar con clientes y proveedores gestionando los contratos mercantiles internacionales y controlando y supervisando el desarrollo y evolución de las ventas para asegurarse del cumplimiento de las condiciones contractuales pactadas.\r\n" +
                                                "- Realizar la gestión administrativa de operaciones de importación y exportación e introducción y expedición de mercancías.\r\n" +
                                                "- Organizar el almacenaje de las mercancías en las condiciones que garanticen su integridad y el aprovechamiento óptimo de los medios y espacios disponibles, de acuerdo con procedimientos establecidos.\r\n" +
                                                "- Realizar las gestiones administrativas que garanticen el tránsito o transporte internacional de las mercancías y/o de viajeros entre distintos países y modos de transporte y controlar los documentos que se exigen en cada caso, comprobando que se ajustan a la normativa vigente aplicable y las especificaciones recibidas.\r\n" +
                                                "- Gestionar los medios de cobro y pago y las garantías y avales internacionales cumplimentando y analizando la documentación necesaria de acuerdo a las condiciones establecidas en los contratos mercantiles internacionales basados en la normativa internacional vigente.\r\n" +
                                                "- Comunicarse con fluidez, tanto de palabra como por escrito, con todos los operadores y organismos que intervienen en operaciones de comercio internacional.\n\n" +
                                                
                                                "PLAN DE FORMACIÓN\n\n" +

                                                "1º Curso\n\n" +
                                                " · Gestión económica y financiera de la empresa\n" +
                                                " · Sistema de información de mercados\n" +
                                                " · Marketing internacional\n" +
                                                " · Negociación internacional\n" +
                                                " · Gestión administrativa del comercio internacional\n" +
                                                " · Financiación internacional\n" +
                                                " · Logística de almacenamiento\n\n" +

                                                "2º Curso\n\n" +
                                                " · Transporte internacional de mercancías\n" +
                                                " · Medios de pago internacionales\n" +
                                                " · Inglés\n" +
                                                " · Comercio digital internacional\n" +
                                                " · Proyecto de comercio internacional\n" +
                                                " · Formación y orientación laboral\n\n" +

                                                "AL FINALIZAR MIS ESTUDIOS, ¿QUÉ PUEDO HACER?\n\n" +

                                                "· Trabajar\r\n" +
                                                "- Técnico en comercio exterior.\r\n" +
                                                "- Técnico de operaciones exteriores de entidades financieras y de seguros.\r\n" +
                                                "- Asistente o adjunto de comercio internacional.\r\n" +
                                                "- Agente de comercio internacional.\r\n" +
                                                "- Técnico de marketing internacional.\r\n" +
                                                "- Técnico de venta internacional.\r\n" +
                                                "- Transitario.\r\n" +
                                                "- Consignatario de buques.\r\n" +
                                                "- Operador logístico.\r\n" +
                                                "- Técnico en logística de l transporte.\r\n" +
                                                "- Coordinador logístico.\r\n" +
                                                "- Técnico en logística inversa.\n\n" +

                                                "· Seguir estudiando\r\n" +
                                                "- Cursos de especialización profesional.\n" + 
                                                "- Otro Ciclo de Formación Profesional de Grado Superior con la posibilidad de establecer convalidaciones de módulos de acuerdo a la normativa vigente.\n" +
                                                "- Enseñanzas Universitarias con la posibilidad de establecer convalidaciones de acuerdo con la normativa vigente.\n" 
                                            ;
                    break;
                case 5:
                    // DAM
                    panelEstudioBio.Visible = true;
                    richTextBoxInfo.Text =

                                                "¿QUÉ VOY A APRENDER A HACER?\r\n\n" +

                                                "- Configurar y explotar sistemas informáticos, adaptando la configuración lógica del sistema según las necesidades de uso y los criterios establecidos.\r\n" +
                                                "- Aplicar técnicas y procedimientos relacionados con la seguridad en sistemas, servicios y aplicaciones, cumpliendo el plan de seguridad.\r\n" +
                                                "- Gestionar bases de datos, interpretando su diseño lógico y verificando integridad, consistencia, seguridad y accesibilidad de los datos.\r\n" +
                                                "- Gestionar entornos de desarrollo adaptando su configuración en cada caso para permitir el desarrollo y despliegue de aplicaciones.\r\n" +
                                                "- Desarrollar aplicaciones multiplataforma con acceso a bases de datos utilizando lenguajes, librerías y herramientas adecuados a las especificaciones.\r\n" +
                                                "- Integrar contenidos gráficos y componentes multimedia en aplicaciones multiplataforma, empleando herramientas específicas y cumpliendo los requerimientos establecidos.\r\n" +
                                                "- Desarrollar interfaces gráficos de usuario interactivos y con la usabilidad adecuada, empleando componentes visuales estándar o implementando componentes visuales específicos.\r\n" +
                                                "- Desarrollar aplicaciones para teléfonos, PDA y otros dispositivos móviles empleando técnicas y entornos de desarrollo específicos.\r\n" +
                                                "- Desarrollar aplicaciones multiproceso y multihilo empleando librerías y técnicas de programación específicas.\r\n" +
                                                "- Participar en la implantación de sistemas ERP-CRM evaluando la utilidad de cada uno de sus módulos.\r\n" +
                                                "- Gestionar la información almacenada en sistemas ERP-CRM garantizando su integridad.\r\n\n\n" +

                                                "PLAN DE FORMACIÓN\n\n" + 

                                                "1º Curso\n\n" +

                                                " · Programación\n" +
                                                " · Bases de Datos\n" +
                                                " · Sistemas Informáticos\n" +
                                                " · Entornos de Desarrollo\n" +
                                                " · Lenguaje de Marcas y Sistemas de Gestión de Información\n" +
                                                " · Formación y Orientación Laboral\n\n" +

                                                "2º Curso\n\n" +

                                                " · Acceso a Datos\n" +
                                                " · Desarrollo de Interfaces\n" +
                                                " · Programación de Servicios y Procesos\n" +
                                                " · Sistemas de Gestión Empresarial\n" +
                                                " · Programación Multimedia y Dispositivos Móviles\n" +
                                                " · Empresas e Iniciativa Emprendedora\n\n" +


                                                "AL FINALIZAR MIS ESTUDIOS, ¿QUÉ PUEDO HACER?\n\n" +

                                                "· Trabajar\r\n" +
                                                "- Desarrollando aplicaciones informáticas para la gestión empresarial y de negocio.\r\n" +
                                                "- Desarrollando aplicaciones de propósito general.\r\n" +
                                                "- Desarrollando aplicaciones en el ámbito del entretenimiento y la informática móvil.\r\n\n" +

                                                "· Seguir estudiando\r\n" +
                                                "- Cursos de especialización profesional.\r\n" +
                                                "- Otro Ciclo de Formación Profesional de Grado Superior con la posibilidad de establecer convalidaciones de módulos de acuerdo a la normativa vigente.\r\n" +
                                                "- Enseñanzas Universitarias con la posibilidad de establecer convalidaciones de acuerdo con la normativa vigente."
                                            ;
                    break;
            }



        }
    }
}

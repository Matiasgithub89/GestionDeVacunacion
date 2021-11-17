using GestionDeVacunacion.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeVacunacion
{
    public partial class Form_GDV : Form
    {
        ArrayList Personas = new ArrayList() ;
        public Form_GDV()
        {
            InitializeComponent();
        }      
       
        private void Form_GDV_Load(object sender, EventArgs e)
        {
            Persona Vacunado1 = new Persona();
            Vacunado1.DNI = 4660592;
            Vacunado1.tipo = "DNI";
            Vacunado1.nombre = "Matias";
            Vacunado1.apellido = "Ludueña";
            Vacunado1.telefono = 3442505696;
            Vacunado1.telEmergencia = 3442525706;
            Vacunado1.email = "matiasluduenia@gmail.com";
            Vacunado1.provincia = "Entre Ríos";
            Vacunado1.ciudad = "Gualeguaychu";
            Vacunado1.calle = "bvard 12 de octubre";
            Vacunado1.numCalle = 1168;
            Vacunado1.otro = "Casa del pino";
            Vacunado1.primeraDosis = "Sputnik";
            Vacunado1.fechaPrimeraDosis = new DateTime(2021, 3, 14);
            Vacunado1.segundaDosis = "Sputnik";
            Vacunado1.fechaSegundaDosis = new DateTime(2021, 3, 14);
            Vacunado1.terceraDosis = "Sputnik";
            Vacunado1.fechaTerceraDosis = new DateTime(2021, 3, 14);
            Personas.Add(Vacunado1);

            Persona Vacunado2 = new Persona();
            Vacunado2.DNI = 4660593;
            Vacunado2.tipo = "DNI";
            Vacunado2.nombre = "Matiass";
            Vacunado2.apellido = "Ludueñaa";
            Vacunado2.telefono = 3442505697;
            Vacunado2.telEmergencia = 3442525707;
            Vacunado2.email = "matiasluduenia2@gmail.com";
            Vacunado2.provincia = "Entre Ríos";
            Vacunado2.ciudad = "Gualeguaychu";
            Vacunado2.calle = "bvard 12 de octubre";
            Vacunado2.numCalle = 1169;
            Vacunado2.otro = "Casa del pino";
            Vacunado2.primeraDosis = "Sputnik";
            Vacunado2.fechaPrimeraDosis = new DateTime(2021, 3, 14);
            Vacunado2.segundaDosis = "Sputnik";
            Vacunado2.fechaSegundaDosis = new DateTime(2021, 3, 14);
            Vacunado2.terceraDosis = "Sputnik";
            Vacunado2.fechaTerceraDosis = new DateTime(2021, 3, 14);
            Personas.Add(Vacunado2);

            dataGridView_Vacunados.DataSource = Personas;
        }
    }
}

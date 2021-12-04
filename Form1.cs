using GestionDeVacunacion.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeVacunacion
{
    public partial class Form_GDV : Form
    {
        //Creamos una array list para guardar las personas
        ArrayList Personas = new ArrayList() ;
        //Creo un array list para Guardar la dosis;
        ArrayList Vacuna = new ArrayList();
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
            Vacunado1.telefono = "3442505696";
            Vacunado1.telEmergencia = "3442525706";
            Vacunado1.email = "matiasluduenia@gmail.com";
            Vacunado1.provincia = "Entre Ríos";
            Vacunado1.ciudad = "Gualeguaychu";
            Vacunado1.calle = "bvard 12 de octubre";
            Vacunado1.numCalle = 1168;
            Vacunado1.otro = "Casa del pino";
            
            Personas.Add(Vacunado1);

            Persona Vacunado2 = new Persona();
            Vacunado2.DNI = 4660593;
            Vacunado2.tipo = "DNI";
            Vacunado2.nombre = "Matiass";
            Vacunado2.apellido = "Ludueñaa";
            Vacunado2.telefono = "3442505697";
            Vacunado2.telEmergencia = "3442525707";
            Vacunado2.email = "matiasluduenia2@gmail.com";
            Vacunado2.provincia = "Entre Ríos";
            Vacunado2.ciudad = "Gualeguaychu";
            Vacunado2.calle = "bvard 12 de octubre";
            Vacunado2.numCalle = 1169;
            Vacunado2.otro = "Casa del pino";
            
            Personas.Add(Vacunado2);

            dataGridView_Vacunados.DataSource = Personas;
        }

        private void pictureBox_Registrar_Click(object sender, EventArgs e)
        {

            validarInput(textBox_Nombre);
            validarInput(textBox_Apellido);
            validarInput(textBox_Dni);
            validarinputNumerico(textBox_Dni);
            validarInput(textBox_Email);
            validarInput(textBox_provincia);
            validarInput(textBox_ciudad);
            validarInput(textBox_CodigoPostal);
            validarinputNumerico(textBox_CodigoPostal);
            validarInput(textBox_Calle);
            validarInput(textBox_Num);
            validarinputNumerico(textBox_Num);
            validarInput(textBox_Otro);

            //Validacion email
            Regex imputImail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.Compiled);
            if (!imputImail.IsMatch(textBox_Email.Text))
            {
                errorProvider1.SetError(textBox_Email, "Ingrese un Correo electronico valido");
                textBox_Email.Focus();
                return;
            }
            errorProvider1.SetError(textBox_Email,"");
            //Fin de Validacion email
            Persona nuevaPersona = new Persona();

            nuevaPersona.nombre = textBox_Nombre.Text;
            nuevaPersona.apellido = textBox_Apellido.Text;
            nuevaPersona.DNI = Convert.ToInt32(textBox_Dni.Text);
            nuevaPersona.tipo = comboBox_TipoDoc.Text;
            nuevaPersona.email = textBox_Email.Text;
            nuevaPersona.telefono = maskedTextBox_Telefono.Text;
            nuevaPersona.telEmergencia = maskedTextBox_Telefono_Emer.Text; ;
            nuevaPersona.provincia = textBox_provincia.Text;
            nuevaPersona.ciudad = textBox_ciudad.Text;
            nuevaPersona.codigoPostal = Convert.ToInt32(textBox_CodigoPostal.Text);
            nuevaPersona.calle = textBox_Calle.Text;
            nuevaPersona.numCalle = Convert.ToInt32(textBox_Num.Text);
            nuevaPersona.otro = textBox_Otro.Text;
           
            Personas.Add(nuevaPersona);
            dataGridView_Vacunados.DataSource = null;
            dataGridView_Vacunados.DataSource = Personas;
            textBox_Nombre.Clear();
            textBox_Apellido.Clear();
            textBox_Dni.Clear();
            textBox_Email.Clear();
            maskedTextBox_Telefono.Clear();
            maskedTextBox_Telefono_Emer.Clear();
            textBox_provincia.Clear();
            textBox_ciudad.Clear();
            textBox_Calle.Clear();
            textBox_Num.Clear();
            textBox_Otro.Clear();
            textBox_Nombre.Focus();

        }
        private void validarInput(TextBox InputTB) {
          
            if (InputTB.Text == "")
            {
                errorProvider1.SetError(InputTB, "Este campo es Obligatorio");
                InputTB.Focus();
                return;
            }
            errorProvider1.SetError(InputTB, "");
        }
        private void validarinputNumerico(TextBox InputNumerico) {
            Decimal _InputNumerico;
            if(!Decimal.TryParse(InputNumerico.Text, out _InputNumerico))
            {
                errorProvider1.SetError(InputNumerico, "Solo debe contener Numeros");
                InputNumerico.Focus();
                return;
            }
        }        
    }
}

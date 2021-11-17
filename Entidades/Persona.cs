using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVacunacion.Entidades
{
    class Persona
    {
        public int DNI { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public double telefono  { get; set; }
        public double telEmergencia { get; set; }
        public string email { get; set; }
        public string provincia { get; set; }
        public string ciudad { get; set; }
        public int codigoPostal { get; set; }
        public string calle { get; set; }
        public int numCalle { get; set; }
        public string otro { get; set; }
        public string primeraDosis { get; set; }
        public DateTime fechaPrimeraDosis { get; set; }
        public string segundaDosis { get; set; }
        public DateTime fechaSegundaDosis { get; set; }
        public string terceraDosis { get; set; }
        public DateTime fechaTerceraDosis { get; set; }

    }
}

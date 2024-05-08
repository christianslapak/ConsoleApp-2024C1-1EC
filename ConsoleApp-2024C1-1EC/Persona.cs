using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2024C1_1EC
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public bool ResponsableInscripto { get; set; }

        public string MostrarDatos()
        {
            string texto = "";
            texto = "Los datos de la persona son: dni_" + DNI + " apellido_" + Apellido + " nombre_" + Nombre;
            return texto;
        }
    }
}

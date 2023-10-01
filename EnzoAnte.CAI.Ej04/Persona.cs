using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoAnte.CAI.Ej04
{
    internal class Persona
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Teléfono { get; set; }

        public string Validar()
        {
            return "Ok";
        }
    }
}

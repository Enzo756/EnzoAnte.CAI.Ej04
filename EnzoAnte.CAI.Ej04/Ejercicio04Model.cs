using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoAnte.CAI.Ej04
{
    internal class Ejercicio04Model
    {
        public string DocumentoIngresado {get; set;}
        public string NombreIngresado { get; set; }
        public string ApellidoIngresado { get; set; }
        public string TipoIngresado { get; set; }
        public string CódigoPaísIngresado { get; set; }
        public string CódigoÁreaIngresado { get; set; }
        public string NúmeroTeléfonoIngresado { get; set; }

        public string Validar()
        {
            return "Ok";
        }
    }
}

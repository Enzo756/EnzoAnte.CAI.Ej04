using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoAnte.CAI.Ej04
{
    internal class Ejercicio04Model
    {
        public List<Persona> Personas = new List<Persona>()
        {
            new Persona {Documento = 43087541, Apellido = "Antezana", Nombre = "Enzo", Teléfono = "1122963574" },
            new Persona {Documento = 42752698, Apellido = "Varela", Nombre = "Ignacio", Teléfono = "1178542698" },
            new Persona {Documento = 40258741, Apellido = "Vito", Nombre = "Tomás", Teléfono = "1145829136" },
            new Persona {Documento = 43102896, Apellido = "Renda", Nombre = "Belén", Teléfono = "1120364485" },
            new Persona {Documento = 43095123, Apellido = "Diaz", Nombre = "Gabriel", Teléfono = "1188542130" },
        };

        internal string Borrar(Persona personaSeleccionada)
        {
            if (personaSeleccionada.Documento == 43087541)
            {
                return "No puede borrar a esta persona.";
            }

            Personas.Remove(personaSeleccionada);
            return null;
        }
    }
}

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

        internal string Borrar(Persona PersonaSeleccionada)
        {
            if (PersonaSeleccionada.Documento == 43087541)
            {
                return "No puede borrar a esta persona.";
            }

            Personas.Remove(personaSeleccionada);
            return null;
        }

        internal string Modificar(Persona PersonaAModificar, Persona PersonaNuevaVersión)
        {
            /*Todas las validaciones imaginables. Algunas modificaciones pueden estar acá y otras van a estar en la Capa de Negocio, la que realmente realiza las operaciones.*/
            if (PersonaNuevaVersión.Documento < 0 || PersonaNuevaVersión.Documento > 99_999_999)
            {
                return "El documento debe ser un número entre 1 y 99.999.999";
            }

            if (string.IsNullOrWhiteSpace(PersonaNuevaVersión.Apellido))
            {
                return "Debe ingresar un apellido.";
            }

            if (PersonaNuevaVersión.Apellido.Length > 50)
            {
                return "El apellido debe tener menos de 50 carácteres";
            }

            //yada yada yada...
            //Si está todo bien hacemos la modificación.

            PersonaAModificar.Documento = PersonaNuevaVersión.Documento;
            PersonaAModificar.Apellido = PersonaNuevaVersión.Apellido;
            PersonaAModificar.Nombre = PersonaNuevaVersión.Nombre;
            PersonaAModificar.Teléfono = PersonaNuevaVersión.Teléfono;
            return null;
        }
    }
}

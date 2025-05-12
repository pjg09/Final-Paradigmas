using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Mecanico : Persona
    {
        //Atributos de control
        private byte longitudMinimaEspecialidad = 5;

        //Atributos de usuario
        private string? especialidad;

        //Constructor
        public Mecanico(string nombre, string telefono, string especialidad) : base(nombre, telefono)
        {
            Especialidad = especialidad;
        }

        //Accesores
        public string? Especialidad { get => especialidad; 
            set => especialidad = !(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)) && value.Length > longitudMinimaEspecialidad ? value : throw new Exception($"Error: la especialidad del mecánico debe tener una longitud de más de {longitudMinimaEspecialidad} carácteres");
        }
    }
}

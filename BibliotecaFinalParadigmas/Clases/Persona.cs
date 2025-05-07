using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    internal abstract class Persona
    {
        private static byte contadorIDs = 1;
        private static byte id;

        //Reglas de negocio
        private readonly byte longitudMinimaNombre = 5, longitudTelefono = 10;
        private readonly char caracterInicialTelefono = '3';

        //Atributos de usuario
        private string? nombre, telefono;

        //Constructor
        public Persona(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;

            id = contadorIDs;
            contadorIDs++;
        }

        //Accesores
        public static byte Id { get => id; }
        public string? Nombre { get => nombre; 
            set => nombre = !(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)) && value.Length > longitudMinimaNombre ? value : throw new Exception($"Error: el nombre debe tener una longitud de más de {longitudMinimaNombre} carácteres"); }

        public string? Telefono { get => telefono; 
            set => telefono = !(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)) && value.Length == 10 && value.StartsWith(caracterInicialTelefono) && value.All(char.IsDigit) ? value : throw new Exception($"Error: el telefono solo puede contener números, debe comenzar en {caracterInicialTelefono} y tener una longitud de {longitudTelefono} caracteres"); }
    }
}

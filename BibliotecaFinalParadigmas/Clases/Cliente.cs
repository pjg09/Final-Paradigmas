using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Cliente : Persona
    {
        //Atributos de usuario
        private bool credito;

        //Atributos de métodos
        private uint saldoEnDeuda;

        //Constructor
        public Cliente(string nombre, string telefono, bool credito) : base(nombre, telefono)
        {
            Credito = credito;

            if (credito)
            {
                saldoEnDeuda = 0;
            }
        }

        //Accesores
        public bool Credito { get => credito; set => credito = value; }
    }
}
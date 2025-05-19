using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Carro
    {
        //Atributos de control
        private readonly byte longPlaca = 6, longMinMarca = 3, longMinModelo = 3;
        private readonly int agnoValidoMin = 1980, agnoValidoMax = DateTime.Now.Year;

        //Hacer get de duegnoCarro para verificar el nombre

        //Atributos de usuario
        private string? placa, marca, modelo;
        private ushort? agno;
        private Cliente duegnoCarro;
        private bool mantimientoFinalizado ;

        //Constructor
        public Carro(string placa, string marca, string modelo, ushort agno, Cliente duegnoCarro)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Agno = agno;
            duegnoCarro = duegnoCarro ;
            mantimientoFinalizado = false;
        }

        
        //Accesores
        //-------------------------------------------------------------------------------------------------------------------------//

        //En DuegnoCarro solamente tenemos el get porque nos interesa solamente traer el dueño carro de la clase Ciente
        internal Cliente DuegnoCarro { get => duegnoCarro; }

        /*
          En placa verificamos:
          Longitud de la placa, que el valor no sea null, 
          que los primeros tres digitos sean letras y los siguientes tres sean numeros 
        */
        public string? Placa { get => placa;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("La placa no puede ser null.");
                }

                if (value.Length < longPlaca)
                {
                    throw new ArgumentException($"La placa debe tener {longPlaca} caracteres.");
                }

                // Verificacion de formato: Debe de tener en las primeras tres posiciones letras, y en las siguientes tres, numeros
                string letras = value.Substring(0, 3);
                string numeros = value.Substring(3, 3);

                bool letrasValidas = letras.All(char.IsLetter);
                bool numerosValidos = numeros.All(char.IsDigit);

                if (!letrasValidas || !numerosValidos)
                {
                    throw new ArgumentException("La placa debe tener el formato: 3 letras seguidas de 3 números (ej. ABC123).");
                }

                placa = value;
            }
        }

        //En marca verificamos longitud del nombre de la marca y que no sea ni null ni whiteSpace
        public string? Marca { get => marca;
            set => marca = !(System.String.IsNullOrEmpty(value)) && !(System.String.IsNullOrWhiteSpace(value)) && value.Length > longMinMarca ? value : throw new Exception($"Error: el nombre de la marca debe tener una longitud de más de {longMinMarca} carácteres");
        }

        //En Modelo verificamos longitud del nombre de la marca y que no sea ni null ni whiteSpace
        public string? Modelo { get => modelo;
            set => modelo = !(System.String.IsNullOrEmpty(value)) && !(System.String.IsNullOrWhiteSpace(value)) && value.Length > longMinModelo ? value : throw new Exception($"Error: el nombre de la marca debe tener una longitud de más de {longMinModelo} carácteres");
        }

        //En agno verificamos que el valor ingresado no sea nulo y esté entre 1980 y 2025
        public ushort? Agno { get => agno;
            set
            {
                if (value == null) //Validacion para que el valor no sea nulo
                {
                    throw new ArgumentException("El año no puede ser nulo.");

                } else if (value < agnoValidoMin || value > agnoValidoMax) //Validacion para que el valor no sea mayor al año actual y menor a 1980
                {
                    throw new ArgumentException($"El año debe estar entre {agnoValidoMin} y {agnoValidoMax}.");
                }

                agno = value;
            }
        }
        public bool MantimientoFinalizado { get => mantimientoFinalizado; set => mantimientoFinalizado = value; }
    }
}

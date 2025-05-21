using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    public class Gasolina : Carro
    {
        //Atributos de control
        private readonly ushort numeroMinCilindros = 3, numeroMaxCilindros = 16;

        //Atributos de usuario
        private ushort numeroCilindros;


        //Constructor
        public Gasolina(string placa, string marca, string modelo, ushort agno, byte numeroCilindros) : base(placa, marca, modelo, agno)
        {
            NumeroCilindros = numeroCilindros;
        }


        //Accesor
        //Verificamos que tenga entre 3 y 16 cilindros 
        public ushort NumeroCilindros { get => numeroCilindros; 
            set => numeroCilindros = value >= numeroMinCilindros && value <= numeroMaxCilindros ? value : throw new Exception($"Error: El vehiculo debe tener entre {numeroMinCilindros} y {numeroMaxCilindros}"); 
        }

    }
}

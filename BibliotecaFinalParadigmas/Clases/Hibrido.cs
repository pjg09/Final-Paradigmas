using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    public class Hibrido : Carro
    {
        //Atributos de control
        private readonly byte numeroMinBaterias = 1, numeroMaxBaterias = 8;
        //Atributos de usuario
        private byte numeroBaterias;


        //Constructor
        public Hibrido(string placa, string marca, string modelo, ushort agno, byte numeroBaterias) : base(placa, marca, modelo, agno)
        {
            NumeroBaterias = numeroBaterias;
        }
        //Accesor para numeroBaterias
        //Verificamos que el carro electrico tenga entre 1 y 8 baterias
        public byte NumeroBaterias { get => numeroBaterias; 
            set => numeroBaterias = value >= numeroMinBaterias && value <= numeroMaxBaterias ? value : throw new Exception($"Error: la cantidad de baterias debe estar entre {numeroMinBaterias} y {numeroMaxBaterias}");
        }
    }
}

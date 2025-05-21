using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    public class Electrico : Carro
    {
        //Atributos de control
        private readonly short autonomiaMin = 200, autonomiaMax = 1000;

        //Atributos de usuario
        private ushort autonomia;


        //Constructor
        public Electrico(string placa, string marca, string modelo, ushort agno, byte autonomia) : base(placa, marca, modelo, agno)
        {
            Autonomia = autonomia;
        }

        //Accesor
        //Verificamos que tenga entre 200km y 1000km de autonomia
        public ushort Autonomia { get => autonomia;
            set => Autonomia = value >= autonomiaMin && value <= autonomiaMax ? value : throw new Exception($"Error: El vehiculo debe tener entre {autonomiaMin}Km de autonomia minima y {autonomiaMax}Km de autonomia max");
        }
    }
}

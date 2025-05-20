using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    internal class Publisher_SalidaCarro
    {
        public event EventHandler<string> CarroSalido;

        public void SacarCarro(string placa)
        {
            Console.WriteLine($"Carro con placa {placa} salió.");

            CarroSalido?.Invoke(this, placa);
        }
    }
}

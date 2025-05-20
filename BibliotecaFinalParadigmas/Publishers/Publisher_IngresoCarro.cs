using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    internal class Publisher_IngresoCarro
    {
        // 1. Declarar el evento
        public event EventHandler<string> CarroIngresado;

        // 2. Método que dispara el evento
        public void IngresarCarro(string placa)
        {
            Console.WriteLine($"Carro con placa {placa} ingresado.");

            // Lanza el evento si hay subscriptores
            CarroIngresado?.Invoke(this, placa);
        }
    }
}

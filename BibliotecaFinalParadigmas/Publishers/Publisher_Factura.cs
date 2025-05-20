using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    internal class Publisher_Factura
    {
        public event EventHandler<string> FacturaGenerada;

        public void GenerarFactura(string datosFactura)
        {
            Console.WriteLine($"Generando factura: {datosFactura}");

            FacturaGenerada?.Invoke(this, datosFactura);
        }
    }
}

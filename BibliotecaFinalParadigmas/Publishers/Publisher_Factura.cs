using BibliotecaFinalParadigmas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    public class Publisher_Factura
    {
        //Delegado
        internal delegate Factura delegado_facturacion();

        //Evento
        internal event delegado_facturacion evento_facturacion;

        //Métodos llamados por los publisher
        public Factura InformarFacturacion (uint valorFactura, bool finalizado, Carro carro)
        {
            if (evento_facturacion != null)
            {
                if (finalizado)
                {
                    return new Factura(valorFactura, carro);
                }
                else
                {
                    throw new Exception("Error: No es posible generar una factura porque el mantenimiento no ha sido finalizado");
                }
            } 
            else
            {
                throw new Exception("Error: No es posible generar una factura porque el evento no fue llamada por el evento correspondiente");
            }
        }
    }
}
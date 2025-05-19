using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Factura
    {
        private static uint contadorIDs = 1;
        private static uint ID;

        //Atributos de métodos
        private bool pagada;
        private uint valorFactura;

        //Evento
        public Publisher_InformarSalida notificacion_salidaCarro; //PENDIENTE PEGAR AL PUBLISHER EN LA APLICACIÓN

        public Factura(uint ValorFactura)
        {
            valorFactura = valorFactura;
            pagada = false;
        }

        //Accesores

        //Mostrar el valor de la factura
        public uint ValorFactura { get => valorFactura; }

        //Mostrar el estado de la factura
        public bool Pagada { get => pagada; }

        //EventHandler
        internal void EventHandler() { }
    }
}

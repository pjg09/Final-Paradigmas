using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFinalParadigmas.Publishers;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Factura
    {
        private static uint contadorIDs = 1;
        private static uint ID;

        //Atributos de métodos
        private bool pagada;
        private uint valorFactura;
        //Dependencia de carro
        private Carro carro;

        //Evento
        public Publisher_SalidaCarro notificacion_salidaCarro; //PENDIENTE PEGAR AL PUBLISHER EN LA APLICACIÓN

        public Factura(uint ValorFactura, Carro carro)
        {
            //valorFactura = valorFactura; Realmente necesario?
            pagada = false;
            this.carro = carro;
        }

        //Accesores

        //Mostrar el valor de la factura
        public uint ValorFactura { get => valorFactura; }

        //Mostrar el estado de la factura
        public bool Pagada { get => pagada; }

        public Carro Carro { get => carro; }

        //EventHandler
        internal string EventHandler() { return ""; }

        public void PagarFactura(uint valorFactura)
        {
            try
            {
                pagada = true;
                notificacion_salidaCarro = new Publisher_SalidaCarro();
                notificacion_salidaCarro.evento_salida += EventHandler;
                notificacion_salidaCarro.InformarSalida(carro, pagada);
                notificacion_salidaCarro.evento_salida -= EventHandler;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}

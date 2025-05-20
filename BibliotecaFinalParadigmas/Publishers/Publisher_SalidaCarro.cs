using BibliotecaFinalParadigmas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    internal class Publisher_SalidaCarro
    {
        //Delegado
        internal delegate string delegado_salida();

        //Evento
        internal event delegado_salida evento_salida;

        //Metodo
        public string InformarSalida(Carro carro, bool pagada) 
        {
            if (evento_salida !=null)
            {
                if (pagada)
                {
                    return $"Se le ha dado salida exitosamente al vehículo de placa {carro.Placa}";
                }
                else
                {
                    throw new Exception($"Error: No se le puede dar salida al carro de placa {carro.Placa} porque la factura no está pagada");
                }
            }
            else
            {
                throw new Exception("Error: No se le puede dar salida al carro porque el evento no fue llamado por el evento correspondiente");
            }
        }
    }
}
using BibliotecaFinalParadigmas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    internal class Publisher_IngresoCarro
    {
        //Delegado
        internal delegate Mantenimiento delegado_ingreso();

        //Evento
        internal event delegado_ingreso evento_ingreso;

        //Método
        public Mantenimiento InformarIngresoCarro (uint valorMantenimiento, Carro carro, List<Mecanico> lista_mecanicos, List<Repuesto> lista_repuestos, List<Trabajo> lista_trabajos)
        {
            if (evento_ingreso != null)
            {
                return new Mantenimiento(valorMantenimiento, carro, lista_mecanicos, lista_repuestos, lista_trabajos);
            }
            else
            {
                throw new Exception("Error: No es posible generar un mantenimiento porque el evento no fue llamado por el evento correspondiente");
            }
        }
    }
}
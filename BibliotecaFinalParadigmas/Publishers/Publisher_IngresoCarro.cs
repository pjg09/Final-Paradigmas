using BibliotecaFinalParadigmas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Publishers
{
    public class Publisher_IngresoCarro
    {
        //Delegado
        internal delegate void delegado_ingreso();

        //Evento
        internal event delegado_ingreso evento_ingreso;

        private List<Mecanico> lista_mecanicos;
        private List<Trabajo> lista_trabajos;
        private List<Repuesto> lista_repuestos;
        private Carro carro;

        //Método
        public void InformarIngresoCarro ()
        {
            if (evento_ingreso != null)
            {
                new Mantenimiento(carro, lista_mecanicos, lista_repuestos, lista_trabajos);
            }
            else
            {
                throw new Exception("Error: No es posible generar un mantenimiento porque el evento no fue llamado por el evento correspondiente");
            }
        }
    }
}
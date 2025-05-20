using BibliotecaFinalParadigmas.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Mantenimiento
    {
        //Atributos de control
        private readonly uint valorMinimoMantenimiento = 10000;
        private readonly byte cantidadMinimaListas = 1;

        //Atributos de métodos
        private DateTime fecha;
        public bool finalizado;
        private bool facturado;

        //Atributos de usuario
        private Carro carro;
        private uint valorMantenimiento;
        private List<Mecanico> lista_mecanicos;
        private List<Trabajo> lista_trabajos;
        private List<Repuesto> lista_repuestos;

        //Evento
        public Publisher_Factura notificacion_facturar;

        //Constructor
        public Mantenimiento(Carro carro, List<Mecanico> lista_mecanicos, List<Repuesto> lista_repuestos, List<Trabajo> lista_trabajos)
        {
            finalizado = false;
            facturado = false;
            lista_mecanicos = new List<Mecanico>();
            lista_repuestos = new List<Repuesto>();
            lista_trabajos = new List<Trabajo>();
        }

        //Accesores

        //Designamos un valor minimo para el mantenimiento
        public uint ValorMantenimiento { get => valorMantenimiento; 
            set => valorMantenimiento = value >= valorMinimoMantenimiento ? value : throw new Exception($"Error: el valor del mantenimiento debe ser minimo de {valorMinimoMantenimiento}"); }

        public List<Mecanico> Lista_mecanicos { get => lista_mecanicos;
            set => lista_mecanicos = value.Count >= cantidadMinimaListas ? value : throw new Exception("Error: La lista de mecanicos no puede estar vacía"); }

        public List<Repuesto> Lista_repuestos { get => lista_repuestos;
            set => lista_repuestos = value.Count >= cantidadMinimaListas ? value : throw new Exception("Error: La lista de repuestos no puede estar vacía"); }

        public List<Trabajo> Lista_trabajos { get => lista_trabajos;
            set => lista_trabajos = value.Count >= cantidadMinimaListas ? value : throw new Exception("Error: La lista de repuestos no puede estar vacía"); }

        //Métodos
        internal Factura EventHandler() 
        {
            return new Factura(valorMantenimiento, carro);
        }

        public void FinalizarMantenimiento ()
        {
            try
            {
                finalizado = true;
                notificacion_facturar = new Publisher_Factura();
                notificacion_facturar.evento_facturacion += EventHandler;
                notificacion_facturar.InformarFacturacion(valorMantenimiento, finalizado, carro); 
                notificacion_facturar.evento_facturacion -= EventHandler;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

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
        private bool finalizado;
        private bool facturado;

        //Atributos de usuario
        private List<Repuesto> lista_repuestos;
        private Carro carro;
        private uint valorMantenimiento;
        private List<Mecanico> lista_mecanicos;
        private List<Trabajo> lista_trabajos;

        //Eventos
        public Publisher_IngresoCarro notificacion_ingresoCarro;
        public Publisher_Facturacion notificacion_facturar;

        //Constructor
        public Mantenimiento(uint valorMantenimiento, Carro carro, List<Mecanico> lista_mecanicos, List<Repuesto> lista_repuestos, List<Trabajo> lista_trabajos)
        {
            finalizado = false;
            facturado = false;
            ValorMantenimiento = valorMantenimiento;
            lista_mecanicos = new List<Mecanico>();
            lista_repuestos 
        }

        //Accesores

        //Designamos un valor minimo para el mantenimiento
        public uint ValorMantenimiento { get => valorMantenimiento; 
            set => valorMantenimiento = value >= valorMinimoMantenimiento ? value : throw new Exception($"Error: el valor del mantenimiento debe ser minimo de {valorMinimoMantenimiento}"); }

        public List<Mecanico> Lista_mecanicos { get => lista_mecanicos;
            set => lista_mecanicos = value.Count >= cantidadMinimaListas ? value : throw new Exception("Error: La lista de mecanicos no puede estar vacía"); }


    }
}

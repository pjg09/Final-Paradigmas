using BibliotecaFinalParadigmas.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    public class Taller
    {
        private readonly byte longitudMinimaNombre = 4, cantidadMinimaListas = 1;

        private List<Mantenimiento> lista_mantenimientos;
        private List<Factura> lista_facturas;
        private string? nombre;
        public Publisher_IngresoCarro notificacion_ingresoCarro;

        public Taller(string nombre)
        {
            Nombre = nombre;
            lista_mantenimientos = new List<Mantenimiento>();
            lista_facturas = new List<Factura>();

            for (byte i = 1; i <= 28; i++)
            {
                new Trabajo();
            }
        }

        public string? Nombre { get => nombre;
            set => nombre = !(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)) && value.Length > longitudMinimaNombre ? value : throw new Exception($"Error: el nombre de la persona debe tener una longitud de más de {longitudMinimaNombre} carácteres"); }

        public List<Mantenimiento> Lista_mantenimientos { get => lista_mantenimientos;
            set => lista_mantenimientos = value.Count >= cantidadMinimaListas ? value : throw new Exception("Error: La lista de mecanicos no puede estar vacía"); }

        public List<Factura> Lista_facturas { get => lista_facturas;
            set => lista_facturas = value.Count >= cantidadMinimaListas ? value : throw new Exception("Error: La lista de mecanicos no puede estar vacía"); }

        internal void EventHandler() { }

        public void IngresoCarro()
        {
            try
            {
                notificacion_ingresoCarro = new Publisher_IngresoCarro();
                notificacion_ingresoCarro.evento_ingreso += EventHandler;
                notificacion_ingresoCarro.InformarIngresoCarro();
                notificacion_ingresoCarro.evento_ingreso -= EventHandler;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
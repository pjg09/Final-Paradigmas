using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    public class Repuesto
    {
        //Atributos de control
        private readonly byte longitudMinimaNombre = 5, longitudMinimaProveedor = 5;

        //Atributos de usuario
        private string? nombre;
        private string? proveedor;

        //Atributos de métodos
        private DateTime fechaCompra;

        //Constructor
        public Repuesto(string nombre, string proveedor)
        {
            fechaCompra = DateTime.Today;
            Nombre = nombre;
            Proveedor = proveedor;
        }

        //Accesores
        public string? Nombre{ get => nombre;
            set => nombre = !(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)) && value.Length > longitudMinimaNombre ? value : throw new Exception($"Error: el nombre del repuesto debe tener una longitud de más de {longitudMinimaNombre} carácteres"); }
        public string? Proveedor { get => proveedor;
            set => proveedor = !(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value)) && value.Length > longitudMinimaProveedor ? value : throw new Exception($"Error: el nombre del proveedor debe tener una longitud de más de {longitudMinimaProveedor} carácteres"); }
    }
}
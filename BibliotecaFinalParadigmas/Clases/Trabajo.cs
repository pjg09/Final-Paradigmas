using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinalParadigmas.Clases
{
    internal class Trabajo
    {
        //Atributos de métodos
        private static byte contadorIDs = 1;
        private static byte id;
        private string? nombre;

        //Constructor universal
        public Trabajo()
        {
            id = contadorIDs;
            contadorIDs++;

            switch(id)
            {
                case 1:
                    nombre = "Cambio de correas";
                    break;

                case 2:
                    nombre = "Cambio de bujías";
                    break;

                case 3:
                    nombre = "Drenado de radiador";
                    break;

                case 4:
                    nombre = "Ajuste de inyectores";
                    break;

                case 5:
                    nombre = "Lubricación del motor";
                    break;

                case 6:
                    nombre = "Cambio de frenos";
                    break;

                case 7:
                    nombre = "Calibracion y recarga de batería";
                    break;

                case 8:
                    nombre = "Examinación de llantas";
                    break;

                case 9:
                    nombre = "Examinación de amortiguación";
                    break;

                case 10:
                    nombre = "Cambio de líquido de frenos";
                    break;

                case 11:
                    nombre = "Revisión del estado de la batería";
                    break;

                case 12:
                    nombre = "Cambio de lubricantes";
                    break;

                case 13:
                    nombre = "Cambio de bombillos";
                    break;

                case 14:
                    nombre = "Cambio de filtro de aire acondicionado";
                    break;

                case 15:
                    nombre = "Cambio de fusibles";
                    break;

                case 16:
                    nombre = "Alineación y balanceo";
                    break;

                case 17:
                    nombre = "Cambio de rines";
                    break;

                case 18:
                    nombre = "Instalación de luces LED";
                    break;

                case 19:
                    nombre = "Instalación de sistema de sonido mejorado";
                    break;

                case 20:
                    nombre = "Instalación de cámara y sensores de reversa";
                    break;

                case 21:
                    nombre = "Polarizado";
                    break;

                case 23:
                    nombre = "Protección nanocerámica para pintura";
                    break;

                case 24:
                    nombre = "Cambio de tapetes";
                    break;

                case 25:
                    nombre = "Cubreasientos";
                    break;

                case 26:
                    nombre = "Cambio de volante";
                    break;

                case 27:
                    nombre = "Reprogramación de la ECU";
                    break;

                case 28:
                    nombre = "Instalación de luces de ambiente";
                    break;
            }
        }

        //Accesores

        //Entregar el valor de ID
        public static byte Id { get => id; }

        //Entregar el nombre
        public string? Nombre { get => nombre; }
    }
}

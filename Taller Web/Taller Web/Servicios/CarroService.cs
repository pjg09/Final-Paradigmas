using BibliotecaFinalParadigmas.Clases;

namespace Taller_Web.Servicios
{
    public class CarroService
    {
        private readonly List<Carro> lista_carros = new();

        public void Agregar(Carro carro)
        {
            lista_carros.Add(carro);
        }

        public IEnumerable<Carro> ObtenerTodos()
        {
            return lista_carros;
        }
    }
}
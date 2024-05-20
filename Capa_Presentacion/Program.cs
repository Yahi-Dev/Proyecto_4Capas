using Capa_Servicio;
using System.Runtime.InteropServices;

namespace Capa_Presentacion
{
    public class Program
    {
        static Persona_Servicios servicios = new Persona_Servicios();

        static void Main(string[] args)
        {
            var personas = servicios.GetPersonas();
            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
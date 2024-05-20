using Capa_Entidades;
using System.Collections.Generic;

namespace Capa_Datos
{
    public class Persona_Datos
    {
        public List<Persona> GetPersonas()
        {
            var result = new List<Persona>();
            result.Add(new Persona { Nombre = "Maria", Apellido = "Perez" });
            result.Add(new Persona { Nombre = "Julio", Apellido = "Martinez" });
            return result;
        }
    }
}

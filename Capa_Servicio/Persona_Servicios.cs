using Capa_Datos;
using Capa_Entidades;
using System.Collections.Generic;

namespace Capa_Servicio
{
    public class Persona_Servicios
    {
        Persona_Datos persona = new Persona_Datos();

        public List<Persona> GetPersonas()
        {
            return persona.GetPersonas();
        }
    }
}

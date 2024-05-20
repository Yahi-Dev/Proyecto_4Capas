namespace Capa_Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                $"Apellido: {Apellido}";
        }
    }
}

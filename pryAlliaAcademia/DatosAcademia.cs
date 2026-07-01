using System.Collections.Generic;

namespace pryAlliaAcademia
{
    public static class DatosAcademia
    {
        public static List<string> Planes = new List<string>();

        public static List<Materia> Materias = new List<Materia>();
    }

    public class Materia
    {
        public string Codigo;
        public string Nombre;
        public string Plan;
        public bool Activo;
    }
}
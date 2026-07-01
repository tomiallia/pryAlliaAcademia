using System.Collections.Generic;

namespace pryAlliaAcademia
{
    public static class DatosAcademia
    {
        public static List<string> Planes = new List<string>()
        {
            "Analista en Sistemas",
            "Desarrollo de Software",
            "Diseño Web"
        };

        public static List<Materia> Materias = new List<Materia>()
        {
            new Materia()
            {
                Codigo = "001",
                Nombre = "programacion",
                Plan = "Analista en Sistemas",
                Activo = true
            },

            new Materia()
            {
                Codigo = "002",
                Nombre = "matemática aplicada",
                Plan = "Analista en Sistemas",
                Activo = true
            },

            new Materia()
            {
                Codigo = "003",
                Nombre = "base de datos",
                Plan = "Desarrollo de Software",
                Activo = true
            }
        };
    }

    public class Materia
    {
        public string Codigo;
        public string Nombre;
        public string Plan;
        public bool Activo;
    }
}
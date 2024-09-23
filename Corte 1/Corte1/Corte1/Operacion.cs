using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1
{
    public class Operacion
    {
        public static int CalcularEdad(Persona persona)
        {
            int edad = DateTime.Now.Year - persona.FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < persona.FechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }

        public static bool EsMayorDeEdad(Persona persona)
        {
            return CalcularEdad(persona) >= 18;
        }
    }

}

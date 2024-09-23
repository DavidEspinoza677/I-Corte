using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public class Registro
    {
        private Persona[] personas;
        private int contador;

        public Registro()
        {
            personas = new Persona[30];  // Máximo 30 personas
            contador = 0;
        }

        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
            }
            else
            {
                MessageBox.Show("El registro está lleno.");
            }
        }

        public Persona[] MostrarPersonas()
        {
            return personas.Take(contador).ToArray(); // Devuelve solo las personas agregadas
        }

        public Persona ObtenerUltimaPersona()
        {
            if (contador > 0)
                return personas[contador - 1];
            else
                return null;
        }
    }


}

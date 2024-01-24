using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV4
{
    public static class Comprobaciones
    {

        public static void ValidarCadena(string cadena)
        {

            // Detección y validación de erroroes

            // Cadena vacía

            if (string.IsNullOrEmpty(cadena))
            {
                throw new Exception("cadena vacía.");
            }

        }

        public static int ValidarHoras(string cadena)
        {

            // CONSTANTES 

            //const int LIMITE = 60;

            // RECURSOS

            int dato;
            dato = 0;

            // Detección y validación de erroroes

            // Cadena vacía

            if (string.IsNullOrEmpty(cadena)) throw new Exception("cadena vacía.");

            // PASAR DE STRING A INT CON CONVERT

            dato = Convert.ToInt32(cadena);

            // VALIDAR MAXIMOS Y MÍNIMOS

            //if (dato > LIMITE) throw new Exception($"supera el maximo permitido, ({int.MinValue} - {LIMITE}).");

            return dato;


        }

        public static float ValidarSalarioHora(string cadena)
        {
            // CONSTANTES
            //const float SALARIO_MAX = 22.5f;
            //const float SALARIO_MIN = 1.0f;

            // RECURSOS LOCALES
            float euros = 0.0f;

            // PROCESO - Detección de errores
            // Detección de la cadena vacía
            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
            // Conversión del valor numérico
            euros = Convert.ToSingle(cadena);
            // Rango de valores
            //if (euros < SALARIO_MIN) throw new Exception($"Valor inferior a {SALARIO_MIN} Euros");
            //if (euros > SALARIO_MAX) throw new Exception($"Valor superior a {SALARIO_MAX} Euros");

            // SALIDA - Método
            return euros;
        }
    }
}

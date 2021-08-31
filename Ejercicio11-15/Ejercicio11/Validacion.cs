using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retono = false;
            if (valor >= min && valor <= max)
            {
                retono = true;
            }
            return retono;
        }
    }
}

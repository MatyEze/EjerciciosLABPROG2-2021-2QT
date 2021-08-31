using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Validacion
    {
        public static bool ValidaS_N(char c)
        {
            bool rt=false;

            if (c == 's' || c == 'S')
            {
                rt = true;
            }

            return rt;
        }
    }
}

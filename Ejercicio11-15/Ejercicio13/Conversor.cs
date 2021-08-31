using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string rt = string.Empty;
            int resultado = num;

            while(resultado > 0)
            {
                string.Concat(rt, (char)resultado % 2);
            }

            return rt;
        }

        public static int BinarioDecimal(string bin)
        {
            int rt = 0;
            int largo = bin.Length;
            char[] CharArray = bin.ToCharArray();
            Array.Reverse(CharArray);

            for (int i = 0; i < largo; i++)
            {
                if (CharArray[i]=='1')
                {
                    rt += (int)Math.Pow(2, i);
                }
            }

            return rt;
        }
    }
}

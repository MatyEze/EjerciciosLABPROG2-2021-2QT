using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Conversor.DecimalBinario(100));
            Console.Write("100101 en Decimal es: ");
            Console.WriteLine(Conversor.BinarioDecimal("100101"));
            Console.Write("420 en Binario es: ");
            Console.WriteLine(Conversor.DecimalBinario(420));
            Console.ReadKey();
        }
    }
}

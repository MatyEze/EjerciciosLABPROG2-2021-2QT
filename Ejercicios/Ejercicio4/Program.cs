using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Nota: Utilizar estructuras repetitivas y selectivas*/
            int count = 0;
            int acumulador = 1;
            int suma;
            do
            {
                suma = 0;
                for (int i = 1; i < acumulador; i++)
                {
                    if (acumulador%i==0)
                    {
                        suma += i;
                    }
                }

                if (suma == acumulador)
                {
                    count++;
                    Console.WriteLine(suma);
                }
                
                acumulador++;
            } while (count<4);
            Console.ReadKey();
        }
    }
}

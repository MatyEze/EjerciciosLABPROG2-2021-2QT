using System;

namespace Ejercicio
{
    class Program
    {
        /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio*/
        static void Main(string[] args)
        {
            int num;
            int min = 0;
            int max = 0;
            float suma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese numero({0}/5): ", i+1);
                int.TryParse(Console.ReadLine(), out num);
                suma += num;

                if (i==0 || num < min)
                {
                    min = num;
                }
                if (i == 0 || num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Minimo = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Promedio = {0}", suma/5);
            Console.ReadKey();
        }
    }
}

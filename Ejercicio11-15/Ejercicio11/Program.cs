using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esValido;
            int num;
            int min=0;
            int max=0;
            float suma=0;
            Console.WriteLine("Ingrese 10 numeros entre -100 y 100:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese numero ({i}/10): ");
                int.TryParse(Console.ReadLine(), out num);
                esValido = Validacion.Validar(num, -100, 100);
                while (esValido == false)
                {
                    Console.Write($"ERROR! Reingrese numero ({i}/10): ");
                    int.TryParse(Console.ReadLine(), out num);
                    esValido = Validacion.Validar(num, -100, 100);
                }
                if (i == 0)
                {
                    min = num;
                    max = min;
                }
                else
                {
                    min = Math.Min(min, num);
                    max = Math.Max(max, num);
                }
                suma += num;
                Console.Clear();
            }
            Console.WriteLine($"El menor numero ingresado fue {min} el mayor {max} y el promedio {suma / 10}");
            Console.ReadKey();
        }
    }
}

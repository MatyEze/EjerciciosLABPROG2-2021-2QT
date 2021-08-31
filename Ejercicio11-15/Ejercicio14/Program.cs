using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            char resp;
            double entrada;
            double entrada2;

            Console.WriteLine("Que desea calcular: ");
            Console.WriteLine("A - Area de cuadrado. ");
            Console.WriteLine("B - Area de triangulo. ");
            Console.WriteLine("C - Area de circulo.\n");
            resp = char.ToLower(Console.ReadKey().KeyChar);

            switch (resp)
            {
                case 'a':
                    Console.Write("\nIngrese longitud de un lado en cm: ");
                    double.TryParse(Console.ReadLine(), out entrada);

                    Console.WriteLine($"\n\nEl area es {CalculoDeArea.CalcularCuadrado(entrada)} cm2");
                    break;
                case 'b':
                    Console.Write("\nIngrese la altura en cm: ");
                    double.TryParse(Console.ReadLine(), out entrada);
                    Console.Write("\nIngrese la base en cm: ");
                    double.TryParse(Console.ReadLine(), out entrada2);

                    Console.WriteLine($"\n\nEl area es {CalculoDeArea.CalcularTriangulo(entrada2, entrada)} cm2");
                    break;
                case 'c':
                    Console.Write("\nIngrese el diametro en cm: ");
                    double.TryParse(Console.ReadLine(), out entrada);

                    Console.WriteLine($"\n\nEl area es {CalculoDeArea.CalcularCirculo(entrada)} cm2");
                    break;
                default:
                    Console.WriteLine("\nERROR! Opcion invalida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se
                debe validar que el número sea 
                mayor que cero, caso contrario,
                mostrar el mensaje: 
                "ERROR. ¡Reingresar número!"
                .
                Nota
                : 
                Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/
            int num = 0;

            Console.Write("Ingresar numero: ");
            int.TryParse(Console.ReadLine(), out num);
            if (num > 0)
            {
                Console.WriteLine("Cuadrado: {0}", Math.Pow(num, 2));
                Console.WriteLine("Cubo: {0}", Math.Pow(num, 3));
            }
            else
            {
                Console.WriteLine("ERROR. !Reingresar numero¡");
            }

            Console.ReadKey();
        }
    }
}

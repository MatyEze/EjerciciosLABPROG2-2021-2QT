using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resp=false;
            int num;
            int suma = 0;
            Console.WriteLine("Ingrese numero para sumar: ");
            do
            {
                Console.Write("\nIngrese numero: ");
                int.TryParse(Console.ReadLine(), out num);
                Console.Write("Desea ingresar otro numero(S/N): ");
                resp = Validacion.ValidaS_N(Console.ReadKey().KeyChar);

                Console.Clear();
                suma += num;
            } while (resp == true);

            Console.WriteLine($"La suma de los numeros es: {suma}");
            Console.ReadKey();
        }
    }
}

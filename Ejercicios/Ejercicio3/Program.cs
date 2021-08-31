using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los 
                números primos 
                que haya hasta el número que ingrese el usuario 
                por consola.
                Nota: 
                Utilizar estructuras repetitivas, selectivas y la función módulo (%)*/
            int fin;
            int count;
            int encontrados=0;
            Console.Write("Ingrese Hasta que numero quiere consultar: ");
            int.TryParse(Console.ReadLine(), out fin);

            for (int i = 2; i <= fin; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0)
                    {
                        count++;
                    }
                }
                if (count==2)
                {
                    Console.WriteLine(i);
                    encontrados++;
                }
            }
            Console.WriteLine($"Se encontraron {encontrados} numeros primos");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double rt = 0;
            rt = lado * lado;
            return rt;
        }
        public static double CalcularTriangulo(double b, double altura)
        {
            double rt = 0;
            rt = (b * altura) / 2;
            return rt;
        }
        public static double CalcularCirculo(double diametro)
        {
            double rt = 0;
            rt = Math.PI * Math.Pow((diametro / 2), 2);
            return rt;
        }
    }
}

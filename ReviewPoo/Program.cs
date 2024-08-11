using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo ();
            Triangulo y = new Triangulo ();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área de X = " + x.Area().ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + y.Area().ToString("F4", CultureInfo.InvariantCulture));
            if (x.Area() > y.Area())
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (A - p) * (B - p) * (C -p));
        }
    }
}
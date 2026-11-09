using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Aportación del socio 1: ");
            double s1 = double.Parse(Console.ReadLine()!);

            Console.Write("Aportación del socio 2: ");
            double s2 = double.Parse(Console.ReadLine()!);

            Console.Write("Aportación del socio 3: ");
            double s3 = double.Parse(Console.ReadLine()!);

            double total = s1 + s2 + s3;
            double pct1 = (s1 / total) * 100;
            double pct2 = (s2 / total) * 100;
            double pct3 = (s3 / total) * 100;
            Console.WriteLine("El porcentaje del socio 1 es {0:F1}%, del socio 2 es {1:F1}% y del socio 3 es {2:F1}%", pct1, pct2, pct3);
        }

}
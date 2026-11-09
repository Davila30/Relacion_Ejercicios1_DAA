using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce el primer valor: ");
            double v1 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce el segundo valor: ");
            double v2 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce el tercer valor: ");
            double v3 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce el cuarto valor: ");
            double v4 = double.Parse(Console.ReadLine()!);

            double suma = v1 + v2 + v3 + v4;
            double promedio = suma / 4;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio}");
        }

}
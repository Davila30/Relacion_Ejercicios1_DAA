using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Número 1: ");
            double n1 = double.Parse(Console.ReadLine()!);
            Console.Write("Número 2: ");
            double n2 = double.Parse(Console.ReadLine()!);
            Console.Write("Número 3: ");
            double n3 = double.Parse(Console.ReadLine()!);
            Console.Write("Número 4: ");
            double n4 = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Suma de los dos primeros: {n1 + n2}");
            Console.WriteLine($"Producto del tercero y cuarto: {n3 * n4}");
        }
}
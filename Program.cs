using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce el valor del lado: ");
            double lado = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"El perímetro del cuadrado es: {4 * lado}");
        }
}
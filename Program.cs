using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce la nota del parcial 1: ");
            double p1 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce la nota del parcial 2: ");
            double p2 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce la nota del examen: ");
            double examen = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce la nota del trabajo final: ");
            double trabajo = double.Parse(Console.ReadLine()!);

            double promedioParciales = (p1 + p2) / 2.0;
            double notaFinal = (promedioParciales * 0.50) + (examen * 0.30) + (trabajo * 0.20);

            Console.WriteLine($"Tu nota final en Desarrollo de Interfaces es: {notaFinal:F2}");
        }

}
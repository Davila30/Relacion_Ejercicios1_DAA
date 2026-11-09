using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce un número: ");
            double num = double.Parse(Console.ReadLine()!);
            double auxiliar = 10; 

            Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
            Console.WriteLine($"Potencia al cubo: {Math.Pow(num, 3)}");
            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(Math.Abs(num))}");
            Console.WriteLine($"Seno: {Math.Sin(num)}");
            Console.WriteLine($"Coseno: {Math.Cos(num)}");
            Console.WriteLine($"Número máximo (entre {num} y {auxiliar}): {Math.Max(num, auxiliar)}");
            Console.WriteLine($"Número mínimo (entre {num} y {auxiliar}): {Math.Min(num, auxiliar)}");
        }
}
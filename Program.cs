using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce el primer número: ");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Introduce el segundo número: ");
            int n2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"La suma es {n1 + n2}");
            Console.WriteLine($"La resta es: {n1 - n2}");
            Console.WriteLine($"La multiplicación es: {n1 * n2}");
            Console.WriteLine($"La división es: {n1 / n2}");
            Console.WriteLine($"El módulo es: {n1 % n2}");
        }
}
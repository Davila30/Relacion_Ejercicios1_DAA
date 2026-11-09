using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce una dirección web o texto: ");
            string texto = Console.ReadLine()!;

            bool resultado = texto.StartsWith("www", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(resultado);
        }

}
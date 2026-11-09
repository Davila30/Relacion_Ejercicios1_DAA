using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            const double PRECIO_HAMBURGUESA = 4.50;
            const double PRECIO_PAPAS = 2.75;
            const double PRECIO_BEBIDA = 1.20;

            Console.Write("Cantidad de hamburguesas: ");
            int hamburguesas = int.Parse(Console.ReadLine()!);

            Console.Write("Cantidad de papas: ");
            int papas = int.Parse(Console.ReadLine()!);

            Console.Write("Cantidad de bebidas: ");
            int bebidas = int.Parse(Console.ReadLine()!);

            double total = (hamburguesas * PRECIO_HAMBURGUESA) + 
                           (papas * PRECIO_PAPAS) + 
                           (bebidas * PRECIO_BEBIDA);

            Console.WriteLine($"Cantidad a pagar: {total:F2}€");

           //Console.ReadKey();
        }
}
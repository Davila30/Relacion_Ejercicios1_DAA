using System;
using System.Collections;

class Bloque1Secuenciales{
        static void Main(string[] args)
        {
            R1_Ejercicio1();
        }
        static void R1_Ejercicio1()
        {
            Console.Write("Introduce el precio del artículo: ");
            double precio = double.Parse(Console.ReadLine()!);

            Console.Write("Introduce la cantidad adquirida: ");
            int cantidad = int.Parse(Console.ReadLine()!);

            double total = precio * cantidad;
            Console.WriteLine($"El coste total es: {total:F2}€");
        }

}
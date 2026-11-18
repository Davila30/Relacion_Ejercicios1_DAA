using System;
using System.Collections;

delegate int Operacion(int a, int b);

class EjerciciosDelegados
{
    static int Sumar(int a, int b) => a + b;
    static int Restar(int a, int b) => a - b;
    static int Multiplicar(int a, int b) => a * b;


    static void Main(string[] args)
    {
        // Ejercicio 3: Multicast Delegates
        Operacion op = Sumar;
        op += Restar;
        op += Multiplicar;

        foreach (Operacion metodo in op.GetInvocationList())
        {
            Console.WriteLine($"Resultado: {metodo(10, 5)}");
        }
    }
}
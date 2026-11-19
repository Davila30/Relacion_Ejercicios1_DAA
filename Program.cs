using System;
using System.Collections;

delegate int Operacion(int a, int b);

class EjerciciosDelegados
{
    static int Sumar(int a, int b) => a + b;
    static int Restar(int a, int b) => a - b;
    static int Multiplicar(int a, int b) => a * b;
    static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return 0;
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        // Ejercicio 3: Multicast Delegates
        Operacion op = Sumar;
        op += Restar;
        op += Multiplicar;
        op += Dividir;

        foreach (Operacion metodo in op.GetInvocationList())
        {
            Console.WriteLine($"Resultado ({metodo.Method.Name}): {metodo(10, 0)}");
        }
    }
}
/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.Write("cuantos numeros desea ingresar: ");
        int cantidad = int.Parse(Console.ReadLine());

        Queue cola = new Queue();

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el entero {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            cola.Enqueue(numero);
        }

        int minimo = int.MaxValue;
        int maximo = 0;

        foreach (int n in cola)
        {
            if (n < minimo)
            {
                minimo = n;
            }

            if (n > maximo)
            {
                maximo = n;
            }
        }

        Console.WriteLine($"minimo: {minimo}");
        Console.WriteLine($"maximo: {maximo}");
    }
}
*/
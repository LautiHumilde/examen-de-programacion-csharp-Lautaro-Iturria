/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList numero = new ArrayList { 0, 1, 11, 12, 15, 19 };
        int[] resultado = adyacentes(numero);

        Console.WriteLine($"Diferencia: {resultado[0]}, Índices: {resultado[1]}, {resultado[2]}");
    }

    static int[] adyacentes(ArrayList n)
    {
        if (n.Count < 2)
        {
            Console.WriteLine("ingrese mas de 2 numeros");
        }

        int m = 0;
        int i1 = 0;
        int i2 = 0;

        for (int i = 1; i < n.Count; i++)
        {
            int Diferencia = (int)n[i] - (int)n[i - 1];

            if (Diferencia > m)
            {
                m = Diferencia;
                i1 = i - 1;
                i2 = i;
            }
        }

        return new int[] { m, i1, i2 };
    }
}
*/
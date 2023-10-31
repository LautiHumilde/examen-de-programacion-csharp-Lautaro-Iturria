using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena: ");
        int cadenas;

        while (!int.TryParse(Console.ReadLine(), out cadenas) || cadenas <= 0)
        {
            Console.WriteLine("pone un numero q no sea 0");
            Console.Write("Ingrese cuantas cadenas vas a poner: ");
        }

        Stack<string> pila = new Stack<string>();

        for (int i = 0; i < cadenas; i++)
        {
            Console.Write($"Ingrese la cadena {i + 1}: ");
            string cadena = Console.ReadLine();
            pila.Push(cadena);
        }

        int sumaConsonantes = consonantes(pila);
        Console.WriteLine($"total de consonantes: {sumaConsonantes}");
    }

    static int consonantes(Stack<string> pila)
    {
        int suma = 0;

        while (pila.Count > 0)
        {
            string palabra = pila.Pop();

            foreach (char letra in palabra)
            {
                if (verificar(letra))
                {
                    suma++;
                }
            }
        }

        return suma;
    }

    static bool verificar(char c)
    {
        return "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(c);
    }
}

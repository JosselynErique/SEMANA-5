using System;
using System.Collections.Generic;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los números ganadores
            List<int> numerosGanadores = new List<int>();

            Console.WriteLine("Introduce los 6 números ganadores de la lotería primitiva:");

            // Pedir al usuario los 6 números
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Introduce el número ganador {i}: ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 49)
                {
                    Console.WriteLine("Por favor, introduce un número válido entre 1 y 49.");
                }
                numerosGanadores.Add(numero);
            }

            // Ordenar la lista de números ganadores de menor a mayor
            numerosGanadores.Sort();

            // Mostrar los números ganadores ordenados
            Console.WriteLine("\nLos números ganadores ordenados de menor a mayor son:");
            foreach (int numero in numerosGanadores)
            {
                Console.WriteLine(numero);
            }
        }
    }
}

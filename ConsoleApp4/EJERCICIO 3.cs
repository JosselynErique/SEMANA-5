using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de asignaturas
            string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            double[] notas = new double[asignaturas.Length];

            // Preguntar al usuario por las notas
            for (int i = 0; i < asignaturas.Length; i++)
            {
                Console.Write($"Introduce la nota para {asignaturas[i]}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("Por favor, introduce una nota válida entre 0 y 10.");
                }
            }

            // Mostrar el resumen de notas
            Console.WriteLine("\nResumen de tus notas:");
            for (int i = 0; i < asignaturas.Length; i++)
            {
                Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
            }
        }
    }
}
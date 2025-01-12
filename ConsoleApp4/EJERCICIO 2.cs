using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de asignaturas
            string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            // Mostrar el mensaje "Yo estudio <asignatura>" para cada asignatura
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}
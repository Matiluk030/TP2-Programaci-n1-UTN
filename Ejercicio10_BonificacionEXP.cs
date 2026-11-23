using System;

class Program
{
    static void Main()
    {
        int[] experiencia = new int[5];
        int experienciaTotal = 0;

        Console.WriteLine("=== BONIFICACION DE EXP ===");

        // Registrar la experiencia de las 5 misiones
        for (int i = 0; i < experiencia.Length; i++)
        {
            Console.Write("Ingrese la EXP de la mision " + (i + 1) + ": ");
            experiencia[i] = int.Parse(Console.ReadLine());
        }

        // Aplicar bonificaciones
        for (int i = 0; i < experiencia.Length; i++)
        {
            if (experiencia[i] > 100)
            {
                int bono = (int)(experiencia[i] * 0.20);
                experiencia[i] += bono;

                Console.WriteLine("Mision " + (i + 1) +
                    ": Bono del 20% aplicado.");
            }
            else
            {
                Console.WriteLine("Mision " + (i + 1) +
                    ": Sin bonificacion.");
            }
        }

        // Mostrar el array actualizado
        Console.WriteLine("\n=== TABLA DE EXPERIENCIA ===");

        for (int i = 0; i < experiencia.Length; i++)
        {
            Console.WriteLine("Mision " + (i + 1) +
                ": " + experiencia[i] + " EXP");

            experienciaTotal += experiencia[i];
        }

        Console.WriteLine("\nExperiencia total acumulada: " +
            experienciaTotal + " EXP");

        Console.WriteLine("\nFin del programa.");
    }
}

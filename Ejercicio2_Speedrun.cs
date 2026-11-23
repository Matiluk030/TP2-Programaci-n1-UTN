using System;

class Program
{
    static void Main()
    {
        float[] tiempos = new float[5];

        Console.WriteLine("=== TOP 5 SPEEDRUN ===");

        // Cargar los tiempos de los 5 corredores
        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.Write("Tiempo del corredor " + (i + 1) + ": ");
            tiempos[i] = float.Parse(Console.ReadLine());
        }

        string continuar = "s";

        // Consultar diferentes tiempos objetivo
        while (continuar == "s")
        {
            Console.Write("\nIngrese el tiempo objetivo: ");
            float objetivo = float.Parse(Console.ReadLine());

            int clasificados = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] <= objetivo)
                {
                    Console.WriteLine("Corredor " + (i + 1) + ": Clasificado");
                    clasificados++;
                }
                else
                {
                    Console.WriteLine("Corredor " + (i + 1) + ": No clasificado");
                }
            }

            Console.WriteLine("\nTotal de clasificados: " + clasificados);

            Console.Write("\n¿Desea probar otro tiempo objetivo? (s/n): ");
            continuar = Console.ReadLine().Trim().ToLower();
        }

        Console.WriteLine("\nFin del programa.");
    }
}

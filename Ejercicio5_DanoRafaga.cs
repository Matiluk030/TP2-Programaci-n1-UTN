using System;

class Program
{
    static void Main()
    {
        int[] danos = new int[6];

        Console.WriteLine("=== REGISTRO DE DANO POR RAFAGA ===");

        // Cargar el dano de las 6 flechas
        for (int i = 0; i < danos.Length; i++)
        {
            Console.Write("Ingrese el dano de la flecha " + (i + 1) + ": ");
            danos[i] = int.Parse(Console.ReadLine());
        }

        string continuar = "s";

        // Consultar diferentes valores de referencia
        while (continuar == "s")
        {
            Console.Write("\nIngrese el dano de referencia: ");
            int referencia = int.Parse(Console.ReadLine());

            int danoTotal = 0;
            int impactosFiltrados = 0;

            Console.WriteLine("\nResultados del filtrado:");

            for (int i = 0; i < danos.Length; i++)
            {
                if (danos[i] > referencia)
                {
                    Console.WriteLine("Flecha " + (i + 1) +
                        ": " + danos[i] + " de dano - Supera la referencia");

                    danoTotal += danos[i];
                    impactosFiltrados++;
                }
                else
                {
                    Console.WriteLine("Flecha " + (i + 1) +
                        ": " + danos[i] + " de dano - No supera la referencia");
                }
            }

            Console.WriteLine("\nImpactos filtrados: " + impactosFiltrados);
            Console.WriteLine("Dano total filtrado: " + danoTotal);

            Console.Write("\nDesea ingresar otra referencia? (s/n): ");
            continuar = Console.ReadLine().Trim().ToLower();
        }

        Console.WriteLine("\nFin del programa.");
    }
}

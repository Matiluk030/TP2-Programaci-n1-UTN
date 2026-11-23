using System;

class Program
{
    static void Main()
    {
        int[] danos = new int[3];

        Console.WriteLine("=== ESTADISTICAS DE FASES DEL BOSS ===");

        // Registrar el dano de las 3 fases
        for (int i = 0; i < danos.Length; i++)
        {
            Console.Write("Ingrese el dano de la fase " + (i + 1) + ": ");
            danos[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSeleccione una opcion:");
        Console.WriteLine("1. Calcular promedio de dano");
        Console.WriteLine("2. Identificar la fase mas destructiva");

        Console.Write("Opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                int total = 0;

                for (int i = 0; i < danos.Length; i++)
                {
                    total += danos[i];
                }

                double promedio = (double)total / danos.Length;

                Console.WriteLine("\nDano total: " + total);
                Console.WriteLine("Promedio de dano: " + promedio);
                break;

            case 2:
                int mayorDano = danos[0];
                int faseMayor = 1;

                for (int i = 1; i < danos.Length; i++)
                {
                    if (danos[i] > mayorDano)
                    {
                        mayorDano = danos[i];
                        faseMayor = i + 1;
                    }
                }

                Console.WriteLine("\nLa fase mas destructiva es la fase "
                    + faseMayor);
                Console.WriteLine("Dano causado: " + mayorDano);
                break;

            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }

        Console.WriteLine("\nFin del programa.");
    }
}

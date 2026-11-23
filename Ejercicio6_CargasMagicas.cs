using System;

class Program
{
    static void Main()
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];

        Console.WriteLine("=== SELECTOR DE ELEMENTOS Y CARGAS MAGICAS ===");

        // Cargar las cargas de cada gema
        for (int i = 0; i < gemas.Length; i++)
        {
            Console.Write("Ingrese las cargas de " + gemas[i] + ": ");
            cargas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSeleccione una opcion:");
        Console.WriteLine("1. Recargar todas las gemas (+5 cargas)");
        Console.WriteLine("2. Buscar gemas agotadas");

        Console.Write("Opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\nRecargando gemas...");

                for (int i = 0; i < cargas.Length; i++)
                {
                    cargas[i] += 5;

                    Console.WriteLine(gemas[i] + ": " +
                        cargas[i] + " cargas");
                }

                Console.WriteLine("Todas las gemas fueron recargadas.");
                break;

            case 2:
                Console.WriteLine("\nBuscando gemas agotadas...");

                bool hayAgotadas = false;

                for (int i = 0; i < cargas.Length; i++)
                {
                    if (cargas[i] == 0)
                    {
                        Console.WriteLine("La gema " + gemas[i] +
                            " esta agotada.");
                        hayAgotadas = true;
                    }
                    else
                    {
                        Console.WriteLine("La gema " + gemas[i] +
                            " tiene " + cargas[i] + " cargas.");
                    }
                }

                if (!hayAgotadas)
                {
                    Console.WriteLine("No hay gemas agotadas.");
                }
                break;

            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }

        Console.WriteLine("\nFin del programa.");
    }
}

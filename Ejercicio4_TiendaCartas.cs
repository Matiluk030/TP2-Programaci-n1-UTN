using System;

class Program
{
    static void Main()
    {
        int[] costos = { 10, 25, 50, 80, 120 };

        Console.WriteLine("=== TIENDA DE CARTAS ===");

        Console.Write("Ingrese la cantidad de gemas: ");
        int gemas = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSeleccione una opcion:");
        Console.WriteLine("1. Mostrar cartas que puede pagar");
        Console.WriteLine("2. Identificar la carta mas cara");

        Console.Write("Opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\nCartas disponibles:");

                bool hayCartas = false;

                for (int i = 0; i < costos.Length; i++)
                {
                    if (gemas >= costos[i])
                    {
                        Console.WriteLine("Carta " + (i + 1) +
                            " - Costo: " + costos[i] + " gemas");
                        hayCartas = true;
                    }
                    else
                    {
                        Console.WriteLine("Carta " + (i + 1) +
                            " - Gemas insuficientes");
                    }
                }

                if (!hayCartas)
                {
                    Console.WriteLine("No puedes comprar ninguna carta.");
                }
                break;

            case 2:
                int mayorCosto = costos[0];
                int cartaMasCara = 1;

                for (int i = 1; i < costos.Length; i++)
                {
                    if (costos[i] > mayorCosto)
                    {
                        mayorCosto = costos[i];
                        cartaMasCara = i + 1;
                    }
                }

                Console.WriteLine("\nLa carta mas cara es la Carta " +
                    cartaMasCara);
                Console.WriteLine("Costo: " + mayorCosto + " gemas");
                break;

            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }

        Console.WriteLine("\nFin del programa.");
    }
}

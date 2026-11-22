using System;

class Program
{
    static void Main()
    {
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] durabilidad = new int[4];

        // Cargar la durabilidad de las armas
        for (int i = 0; i < armas.Length; i++)
        {
            Console.Write("Ingrese la durabilidad de " + armas[i] + ": ");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        int opcion = 0;

        // Menu principal
        while (opcion != 3)
        {
            Console.WriteLine("\n=== INVENTARIO DE ARMAS ===");
            Console.WriteLine("1. Inspeccionar armas criticas");
            Console.WriteLine("2. Ver arsenal completo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n=== ARMAS CRITICAS ===");

                    bool hayCriticas = false;

                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine(armas[i] +
                                " - Durabilidad: " + durabilidad[i]);
                            hayCriticas = true;
                        }
                    }

                    if (!hayCriticas)
                    {
                        Console.WriteLine("No hay armas criticas.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n=== ARSENAL COMPLETO ===");

                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine(armas[i] +
                            " - Durabilidad: " + durabilidad[i]);
                    }
                    break;

                case 3:
                    Console.WriteLine("Saliendo del inventario...");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] municion = { 30, 15, 8 };
        string[] armas = { "Rifle", "Pistola", "Escopeta" };

        int opcion = -1;

        Console.WriteLine("=== SISTEMA DE MUNICION ===");

        while (opcion != 0)
        {
            Console.WriteLine("\nArmas disponibles:");

            for (int i = 0; i < armas.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + armas[i] +
                    " - Balas: " + municion[i]);
            }

            Console.WriteLine("0. Salir");
            Console.Write("Seleccione un arma para disparar: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese una opcion valida.");
                opcion = -1;
                continue;
            }

            switch (opcion)
            {
                case 1:
                case 2:
                case 3:
                    int indice = opcion - 1;

                    if (municion[indice] > 0)
                    {
                        municion[indice]--;

                        Console.WriteLine("Disparo realizado con " +
                            armas[indice] + ".");

                        Console.WriteLine("Balas restantes: " +
                            municion[indice]);
                    }
                    else
                    {
                        Console.WriteLine("El arma esta vacia. No puedes disparar.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }

        Console.WriteLine("\nFin del programa.");
    }
}

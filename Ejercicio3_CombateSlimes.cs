using System;

class Program
{
    static void Main()
    {
        int[] slimes = { 30, 40, 50, 60 };
        bool haySlimesVivos = true;

        Console.WriteLine("=== COMBATE CONTRA HORDA DE SLIMES ===");

        while (haySlimesVivos)
        {
            Console.WriteLine("\nEstado de los slimes:");

            for (int i = 0; i < slimes.Length; i++)
            {
                Console.WriteLine("Slime " + i + ": " + slimes[i] + " HP");
            }

            Console.Write("\nElige un slime para atacar (0 al 3): ");
            int opcion;

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Debes ingresar un numero valido.");
                continue;
            }

            switch (opcion)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    if (slimes[opcion] <= 0)
                    {
                        Console.WriteLine("Este slime ya fue derrotado.");
                    }
                    else
                    {
                        slimes[opcion] -= 20;

                        if (slimes[opcion] <= 0)
                        {
                            slimes[opcion] = 0;
                            Console.WriteLine("Slime derrotado!");
                        }
                        else
                        {
                            Console.WriteLine("Ataque exitoso! Vida restante: "
                                + slimes[opcion] + " HP");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida. Elige del 0 al 3.");
                    break;
            }

            haySlimesVivos = false;

            for (int i = 0; i < slimes.Length; i++)
            {
                if (slimes[i] > 0)
                {
                    haySlimesVivos = true;
                }
            }
        }

        Console.WriteLine("\nVictoria! Todos los slimes fueron derrotados.");
    }
}

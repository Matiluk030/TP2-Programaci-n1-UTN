using System;

class Program
{
    static void Main()
    {
        bool[] trampas = { false, true, false, false, true, false };

        int posicion = -1;
        bool perdio = false;

        Console.WriteLine("=== PASILLO DE MAZMORRA ===");
        Console.WriteLine("Debes llegar a la baldosa 5 sin pisar trampas.");

        while (!perdio && posicion < 5)
        {
            Console.WriteLine("\nPresiona ENTER para avanzar...");
            Console.ReadLine();

            posicion++;

            Console.WriteLine("Avanzaste a la baldosa " + posicion);

            if (trampas[posicion])
            {
                Console.WriteLine("Cuidado! Pisaste una trampa.");
                Console.WriteLine("Has perdido la partida.");
                perdio = true;
            }
            else
            {
                Console.WriteLine("Baldosa segura.");

                if (posicion == 5)
                {
                    Console.WriteLine("Felicidades! Llegaste a la meta.");
                }
            }
        }

        Console.WriteLine("\nFin del juego.");
    }
}

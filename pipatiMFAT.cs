using System;

class PiedraPapelTijera
{
    static void Main()
    {
        string[] opciones = { "piedra", "papel", "tijera" };
        Random rnd = new Random();
        string jugador;

        int victorias = 0;
        int derrotas = 0;
        int empates = 0;

        Console.WriteLine("Bienvenido a Piedra, Papel o Tijera!");

        while (true)
        {
            Console.Write("Escribe piedra, papel, tijera o salir: ");
            jugador = Console.ReadLine().ToLower();

            if (jugador == "salir")
            {
                Console.WriteLine("Gracias por jugar.");
                Console.WriteLine("Ganadas: " + victorias);
                Console.WriteLine("Perdidas: " + derrotas);
                Console.WriteLine("Empates: " + empates);
                break;
            }

            if (Array.IndexOf(opciones, jugador) < 0)
            {
                Console.WriteLine("Opción inválida. Intenta nuevamente.");
                continue;
            }

            string compu = opciones[rnd.Next(opciones.Length)];
            Console.WriteLine("La computadora eligió: " + compu);

            if (jugador == compu)
            {
                Console.WriteLine("Empate.");
                empates++;
            }
            else if ((jugador == "piedra" && compu == "tijera") ||
                     (jugador == "tijera" && compu == "papel") ||
                     (jugador == "papel" && compu == "piedra"))
            {
                Console.WriteLine("Ganaste.");
                victorias++;
            }
            else
            {
                Console.WriteLine("Perdiste.");
                derrotas++;
            }

            Console.WriteLine("Marcador: Ganadas=" + victorias + " Perdidas=" + derrotas + " Empates=" + empates);
        }
    }
}

using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar número secreto entre 1 y 100
            int numeroSecreto = Random.Shared.Next(1, 101);
            int intentoUsuario = 0;
            int contadorIntentos = 0;

            Console.WriteLine("========================================");
            Console.WriteLine("         JUEGO: ADIVINA EL NÚMERO       ");
            Console.WriteLine("========================================");
            Console.WriteLine("He pensado en un número entre 1 y 100. ¡Intenta adivinarlo!");

            // Ciclo hasta que el usuario acierte
            do
            {
                Console.Write("\nIngresa tu suposición: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intentoUsuario))
                {
                    contadorIntentos++;

                    if (intentoUsuario < numeroSecreto)
                    {
                        Console.WriteLine("Demasiado bajo... Pista: Es mayor.");
                    }
                    else if (intentoUsuario > numeroSecreto)
                    {
                        Console.WriteLine("Demasiado alto... Pista: Es menor.");
                    }
                    else
                    {
                        Console.WriteLine("\n¡Felicidades! ¡Has adivinado el número secreto!");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Ingresa un número entero válido.");
                }

            } while (intentoUsuario != numeroSecreto);

            // Mostrar el total de intentos al final
            Console.WriteLine("========================================");
            Console.WriteLine($"Número total de intentos: {contadorIntentos}");
            Console.WriteLine("========================================");
        }
    }
}

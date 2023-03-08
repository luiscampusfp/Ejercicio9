using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        /*
         Ante un numero de errores, me diga qu he perdido,
        Que al final muestre la cantidad de errores, y el tiempo que demoro en adivinar la palabra.
        Si es posible añadir un componente grafico para que el jugador vea el dibujo ahorcado.
         */
        static void Main(string[] args)
        {
            
            string letras = "";
            int intentos = 0;
            Console.WriteLine("Entre la palabra a adivinar");
            string palabra = Console.ReadLine();
            DateTime inicio = DateTime.Now;
            do
            {
                Console.Clear();
                if (mostrarPalabra(palabra, letras))
                {
                    mostrarDibujo(intentos);
                    break;
                }
                mostrarDibujo(intentos);

                Console.WriteLine("Adivina una letra");
                char letra = Console.ReadLine()[0];
                if (palabra.Contains(letra))
                {
                    letras += letra;
                }
                else
                {
                    intentos++;
                    if (intentos == 6)
                    {
                        break;
                    }
                }
            } while (true);
            DateTime hfin = DateTime.Now;
            TimeSpan tiempo = hfin - inicio;
            if (intentos < 6)
            {
                Console.WriteLine("Has ganado.");
            }
            else
            {
                Console.WriteLine("Lo siento has perdido.");
            }
            Console.WriteLine("Has demorado " + tiempo.Minutes + ":" + tiempo.Seconds + " segundos.");
            Console.ReadLine();
        }

        public static bool mostrarPalabra(string palabra, string letras)
        {
            bool fin = true;
            foreach (char c in palabra)
                if (letras.Contains(c))
                {
                    Console.Write(c + " ");
                }
                else
                {
                    Console.Write("_ ");
                    fin = false;
                }
            Console.WriteLine("\n");

            return fin;
        }

        public static void mostrarDibujo(int intentos)
        {
            switch (intentos)
            {
                case 0:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "      |\n" +
    "      |\n" +
    "      |\n" +
    "      |\n" +
    "========="
    );
                    break;
                case 1:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "  0   |\n" +
    "      |\n" +
    "      |\n" +
    "      |\n" +
    "========="
    );
                    break;
                case 2:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "  0   |\n" +
    "  |   |\n" +
    "      |\n" +
    "      |\n" +
    "========="
    );
                    break;
                case 3:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "  0   |\n" +
    " /|   |\n" +
    "      |\n" +
    "      |\n" +
    "========="
    );
                    break;
                case 4:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "  0   |\n" +
    " /|\\  |\n" +
    "      |\n" +
    "      |\n" +
    "========="
    );
                    break;
                case 5:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "  0   |\n" +
    " /|\\  |\n" +
    " /    |\n" +
    "      |\n" +
    "========="
    );
                    break;
                case 6:
                    Console.WriteLine(
    "  +---+\n" +
    "  |   |\n" +
    "  0   |\n" +
    " /|\\  |\n" +
    " / \\  |\n" +
    "      |\n" +
    "========="
    );
                    break;

            }
        }
    }
}

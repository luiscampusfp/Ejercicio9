using System;
using System.Collections.Generic;
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
            Console.WriteLine("Entre la palabra a adivinar");
            string palabra = Console.ReadLine();
            bool fin;
            do
            {
                Console.Clear();
                fin = mostrarPalabra(palabra, letras);

                Console.WriteLine("Adivina una letra");
                char letra = Console.ReadLine()[0];
                if (palabra.Contains(letra))
                {
                    letras += letra;
                }
            } while (!fin);
            Console.WriteLine("Has ganado.");
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
    }
}

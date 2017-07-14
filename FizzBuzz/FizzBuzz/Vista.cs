using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Vista
    {
        Modelo modelo;

        public Vista(Modelo modelo)
        {
            this.modelo = modelo;
        }

        public void menuInicial()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al juego FIZZ BUZZ \n");
            Console.WriteLine("Presione Enter para iniciar");
        }

        public void respuestaJugador()
        {
            Console.WriteLine("Seleccione el numero junto a la palabra");
            Console.WriteLine("3-  FIZZ");
            Console.WriteLine("5-  BUZZ");
            Console.WriteLine("35- FIZZ BUZZ");
            Console.WriteLine("0-  Pasar");
        }

        public void mostrarNumero(int numero)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(numero);
            Console.WriteLine("\n");
        }

        public void perdio()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Has Perdido NAAB");
            Console.WriteLine("Presione Enter para reiniciar");
        }

    }
}

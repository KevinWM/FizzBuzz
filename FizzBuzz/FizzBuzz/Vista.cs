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
            Console.WriteLine("Bienvenido al juego FIZZ BUZZ \n");
            Console.WriteLine("Presione Enter para iniciar");
        }
    }
}

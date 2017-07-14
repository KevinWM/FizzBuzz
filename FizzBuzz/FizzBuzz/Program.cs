using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            Modelo modelo = new Modelo();
            Vista vista = new Vista(modelo);
            Controlador controlador = new Controlador(modelo, vista);

            controlador.iniciarJuego();
            }
        }
    }
}

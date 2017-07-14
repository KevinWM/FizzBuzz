using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{

    class Controlador
    {
        Vista vista;
        Modelo modelo;

        public Controlador(Modelo modelo, Vista vista)
        {
            this.modelo = modelo;
            this.vista = vista;
        }

        public void iniciarJuego()
        {
            this.vista.menuInicial();
            Console.ReadKey();
        }
    }
}

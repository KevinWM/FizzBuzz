using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.ReadLine();
            while (true)
            {
                int numero = this.modelo.numero;
                this.vista.mostrarNumero(numero);
                this.vista.respuestaJugador();
                string seleccion = Console.ReadLine();

                if (seleccion == "3")
                {
                    if ((isDivisible3(numero) == false) || (isDivisible5(numero) == true))
                        break;
                }
                if (seleccion == "5")
                {
                    if ((isDivisible3(numero) == true) || (isDivisible5(numero) == false))
                        break;
                }
                if (seleccion == "35")
                {
                    if ((isDivisible3(numero) == false) || (isDivisible5(numero) == false))
                        break;
                }
                if (seleccion == "0")
                {
                    if ((isDivisible3(numero) == true) || (isDivisible5(numero) == true))
                        break;
                }

                this.modelo.aumentarNumero();
            }

            this.vista.perdio();
            Console.ReadLine();
        }

        private Boolean isDivisible3(int numero)
        {
            bool isDivisible3 = this.modelo.isNumeroDivisible3(numero);
            if (isDivisible3)
                return true;
            return false;
        }

        private Boolean isDivisible5(int numero)
        {
            bool isDivisible5 = this.modelo.isNumeroDivisible5(numero);
            if (isDivisible5)
                return true;
            return false;
        }

        private void respuestaJugador()
        {
        }
    }
}

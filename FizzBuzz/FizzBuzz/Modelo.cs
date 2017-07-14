using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Modelo
    {

        public int numero;

        public Modelo()
        {
            numero = 1;
        }

        public void aumentarNumero()
        {
            numero++;
        }

        public Boolean isNumeroDivisible3(int numero)
        {
            if (numero % 3 == 0)
                return true;
            return false;
        }

        public Boolean isNumeroDivisible5(int numero)
        {
            if (numero % 5 == 0)
                return true;
            return false;
        }
    }

}

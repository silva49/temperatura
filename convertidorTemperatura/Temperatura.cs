using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertidorTemperatura
{
     public class Temperatura
    {
        private double numero1;

        public void setNumero1(double celsius)
        {

            this.numero1 = celsius;
        }


        public double getNumero1()
        {
            return this.numero1;
        }

        public double resultado()
        {
            return ((this.getNumero1() * 9/5) + 32);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_C
{
    class Sumac
    {
        //atributos
        private double num1;
        private double num2;

        public Sumac(double n1, double n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public Sumac(double n1)
        {
            this.num1 = n1;
        }
        //Metodo 
        public double suma()
        { 
            return (num1 + num2);
        }
    }
}

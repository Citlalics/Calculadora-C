using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_C
{
    class Restac
    {
        
        private double num1;
        private double num2;

        public Restac(double n1, double n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public Restac(double n1)
        {
            this.num1 = n1;
        }
        
        public double resta()
        {
            return (num1 - num2);
        }
    }
}

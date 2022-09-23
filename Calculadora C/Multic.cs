using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_C
{
    class Multic
    {
        
        private double num1;
        private double num2;

        public Multic(double n1, double n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public Multic(double n1)
        {
            this.num1 = n1;
        }
        
        public double multi()
        {
            return (num1 * num2);
        }
    }
}

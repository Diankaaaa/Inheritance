using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Complex_number2 : Complex_number
    {
        public double a2 { get; set; }
        public double b2 { get; set; }

        public Complex_number2(double a2, double b2)
        {
            this.a2 = a2;
            this.b2 = b2;
        }
        public double multiplication(double a1, double b1, double a2, double b2) 
        {
            return (a1*a2-b1*b2) + (a1 * b2 + a2 * b1);
        }
    }
}

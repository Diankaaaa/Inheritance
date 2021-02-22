using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Complex_number
    {
        public double a1 { get; set; } //Действительная часть числа
        public double b1 { get; set; } //Мнимая часть числа

        //Конструктор
        public Complex_number(double a1, double b1)
        {
            this.a1 = a1;
            this.b1 = b1;
        }

        //Функция вычисления модуля
        public double ABC()
        {
            return Math.Sqrt(a1 * a1 + b1 * b1);
        }

        //Функция получения обратного числа
        public double getReverseNumberA()
        {
            double d = ((a1 * a1) + (b1 * b1));
            return a1 / d;
        }
        public double getReverseNumberB()
        {
            double d = ((a1 * a1) + (b1 * b1));
            return -b1 / d;
        }
    }
}


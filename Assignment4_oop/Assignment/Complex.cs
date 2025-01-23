using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_oop.Assignment
{
    internal class Complex
    {
        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public Complex(){ }

        public int Real { get; set; }
        public int Imag { get; set; }


        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }


        // overloading +
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0 ) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }


        // overloading -
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }

    }
}

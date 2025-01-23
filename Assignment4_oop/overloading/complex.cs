using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_oop.overloading
{
    internal class complex
    {
        public complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }
        public complex() { }

        public int Real { get; set; }
        public int Imag { get; set; }



        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }


        // Binary Operator
        // public static type operator [+,/,*,-,%](left , right) {}

         
        #region Binary Operator Overloading

        // adding
        public static complex operator +(complex left, complex right)
        {
            return new complex
            {
                Real = left.Real + right.Real,
                Imag = left.Imag + right.Imag
            };
        }

        // subtracting
        public static complex operator -(complex left, complex right)
        {
            return new complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = ((left?.Imag ?? 0)) - ((right?.Imag ?? 0))
            };
        }


        #endregion


        

        #region Unary Operator Overloading
        // Unary Oerator
        public static complex operator ++(complex input)
        {
            return new complex
            {
                Real = (input?.Real ?? 0) + 1 ,
                Imag = (input?.Imag ?? 0)

            };

        }

        #endregion


        #region Relational Operator Overloading
        // Relational Operator
        public static bool operator >(complex left, complex right)
        {
            if (left?.Real == right?.Real)
               return left?.Imag > right?.Imag;
            return left?.Real > right?.Real;
        }


        public static bool operator <(complex left, complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag < right?.Imag;
            return left?.Real < right?.Real;
        }

        #endregion


        #region Casting

        // implicit
        public static implicit operator  complex(int input)
        {
            return new complex
            {
                Real = input,
                Imag = 0
            };
        }

        // explicit
        public static explicit operator int(complex input)
        {
            return input?.Real ?? 0;
        }


        #endregion

    }
}

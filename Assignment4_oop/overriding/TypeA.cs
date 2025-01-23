using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_oop.overriding
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public override string ToString()
        {
            return $"TypeA => {A}";
        }

        public void Function01()
        {
            Console.WriteLine("Function 01 Type A");
        }

        virtual public void Function02()
        {
            Console.WriteLine($"Function 01 Type A => {A}");
        }

    }
}

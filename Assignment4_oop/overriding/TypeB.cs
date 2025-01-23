using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_oop.overriding
{
    internal class TypeB :TypeA
    {
        public TypeB(int a ,int b) : base(a)
        {
            B = b;
        }

        public int B { get; set; }


        new public void Function01()
        {
            Console.WriteLine("Function 01 Type B");
        }

         public override void Function02()
        {
            Console.WriteLine($"Function 01 Type B => {B}");
        }
    }
}

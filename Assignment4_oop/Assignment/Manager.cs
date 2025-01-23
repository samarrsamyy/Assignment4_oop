using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_oop.Assignment
{
    internal class Manager : Employee
    {

        public override void Works()
        {
            Console.WriteLine("Manager is managing");
        }
    }
}

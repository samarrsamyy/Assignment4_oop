
using Assignment4_oop.Assignment;
//using Assignment4_oop.overloading;
//using Assignment4_oop.overriding;

namespace Assignment4_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo

            //complex c1 = new complex(5,3);
            //complex c2 = new complex(7,2);


            //complex c3 = c1++; // 6+3!
            ////Console.WriteLine($"C1 = {c1}");
            ////Console.WriteLine($"C3 = {c3}");

            ////Console.WriteLine(c1 > c2);

            //complex c4 = 50;
            //int c5 = (int) c1;
            ////Console.WriteLine(c4);
            ////Console.WriteLine(c5);

            //TypeA typeARef = new TypeA(10);

            //typeARef.A = 12;
            ////typeARef.Function02();

            //TypeB typeBRef = new TypeB(90,20);

            //typeBRef.Function01();

            //#region Binding

            //TypeA typeA = new TypeB(10,20); // implicit cast => inheritance

            //typeA.Function01(); // non virtual methos resolve at compile time based in the type of reference 
            ////                      Static binging || Early binding           

            //typeA.Function02(); // virtual method override using override keyword Resolve at Runtime based on the type of object
            //                    //                      Dynamic Binding || Late Binding

            #endregion





            #region Assignment 4

            #region Part 01
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
            //Calculator cal = new();

            //Console.WriteLine(cal.Add(1, 2)); // 2 int
            //Console.WriteLine(cal.Add(1, 2, 3)); // 3 int
            //Console.WriteLine(cal.Add(1.1, 1.1)); // 2 double




            #endregion

            #region Q2) Create a class named Rectangle with the following constructors:

            //Rectangle rectangle01 = new Rectangle();

            //Console.WriteLine($"Rectangle01:\n{rectangle01}\n\n");


            //Rectangle rectangle02 = new Rectangle(10, 20);

            //Console.WriteLine($"Rectangle02:\n{rectangle02}\n\n");


            //Rectangle rectangle03 = new Rectangle(30);

            //Console.WriteLine($"Rectangle03:\n{rectangle03}\n\n");

            #endregion

            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
            //Complex comp1 = new(5 , 2);
            //Complex comp2 = new(3 , 1);

            //Console.WriteLine($"Adding => {comp1 + comp2}");
            //Console.WriteLine($"Subtracting => {comp1 - comp2}");



            #endregion

            #region Q4) Create a base class named Employee -- Create a derived class named Manager that overrides the Work method
            //Employee employee = new Employee();
            //Manager manager = new Manager();
            //Employee employee1 = new Manager();

            //employee.Works();
            //manager.Works();
            //employee1.Works();

            #endregion

            #region Question 5) 
            //BaseClass BaseC = new BaseClass();
            //BaseC.DisplayMessage();
            //// refers to BaseClass


            //BaseClass BaseC1 = new DerivedClass1();
            //BaseC1.DisplayMessage();
            //// refers to Derived1 =>  virtual method override , Resolve at Runtime 
            ////// override/remove the original method

            //BaseClass BaseC2 = new DerivedClass2();
            //BaseC2.DisplayMessage();
            //// refers to Derived2 => non virtual methos resolve at compile time 
            //////   create new reference of the method                 








            #endregion


            #endregion


            #region  Part 02
            //Duration D1 = new(1,10,15); 

            Duration D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());


            Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(666);

            //D3 = D1 + D2;

            //D3 = D1 + 7800;

            //D3 = 666 + D3;
            //D3 = ++D1;
            //D3 = --D2;
            //D1 = D1 - D2;

            //Console.WriteLine(D3.ToString());

            //Console.WriteLine(D1 <=  D2);

            //if (D1)
            //{
            //    Console.WriteLine($"D1 has a positive duration = {D1.totalSeconds}");
            //}
            //else
            //{
            //    Console.WriteLine($"D1 has no duration\n{D1.ToString()}");
            //}

            DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);

            Console.WriteLine(D1.GetHashCode());




            #endregion



            #endregion
        }
    }
}

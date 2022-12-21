using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            ClassAssignment.cAssignment(number); // instantiate class/call method on number


            // output parameter call
            int outputData;
            ClassAssignment.cAssignment(out outputData);
            Console.WriteLine("Output data: " + outputData); // print the data

            Console.ReadLine(); // display the output
        }
    }

    static class ClassAssignment // create a class, declared static
    {
        public static void cAssignment(int someData) // create a void method that outputs an integer
        {
            int methodDivide = someData / 2; // Have the method divide the data passed to it by 2.
            Console.WriteLine("Your number / 2 = " + methodDivide);
        }

        public static void cAssignment(out int otherData) // create a method with output parameters, overload a method
        {
            otherData = 100;
        }
    }
}

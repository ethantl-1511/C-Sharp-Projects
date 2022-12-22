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
            FirstClass.cAssignment(number); // instantiate class/call method on number


            // output parameter call
            int outputData;
            FirstClass.cAssignment(out outputData);
            Console.WriteLine("Output data: " + outputData); // print the data

            SecondClass.StaticMethod(""); // static class call.

            Console.ReadLine(); // display the output
        }
    }
}

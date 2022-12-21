using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int AddResult = SimpleMath.Add(num); // instantiate the class and call the one method
            Console.WriteLine("10 + 100: " + AddResult); // display results

            double dnum = 1.14515627;
            double DoubleResult = SimpleMath.Add(dnum); // instantiate the class and call the one method
            Console.WriteLine("1.14515627 + 100.25: " + DoubleResult); // display results

            Console.WriteLine("Give a number to do another math operation on:");
            uint unum = Convert.ToUInt32(Console.ReadLine());
            uint uAddResult = SimpleMath.Add(unum);  // instantiate the class and call the one method
            Console.WriteLine("Your number + 100: " + uAddResult); // display results

            Console.ReadLine();
        } 

    }

    class SimpleMath // Create a class
    {
        public static int Add(int num) // create a method
        {
            return (num + 100);
        }

        public static double Add(double dnum) // add a second method, same name, takes a decimal
        {
            return (dnum + 100.25);
        }

        public static uint Add(uint unum) // create a third method, same name
        {
            return (unum + 100);
        }
    }
}

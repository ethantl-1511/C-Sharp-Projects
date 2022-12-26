using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = 1; // age will be 1 by default, we don't want zeroes
                bool validAnswer = false; // validAnswer will be false
                while (!validAnswer) // while-loop to do checks, we want positive numbers only.
                {
                    Console.Write("Please input your age: ");
                    int check = Convert.ToInt32(Console.ReadLine()); // first check, is number above 0?
                    if (check < 0)
                    {
                        throw new Exception(); // if it is, throw exception
                    }
                    validAnswer = int.TryParse(Console.ReadLine(), out age); // now we're checking for digits-only, no strings
                    if (!validAnswer) throw new Exception(); // if it's anything but a number, throw an exception
                    Console.WriteLine(DateTime.Now.AddYears(-age)); // otherwise, take the age and subtract it from today's date.
                }
            }
            catch (Exception) // general exception
            {
                Console.WriteLine("Something went wrong. Try putting in a whole number."); 
            }
            Console.ReadLine();
        }
    }
}

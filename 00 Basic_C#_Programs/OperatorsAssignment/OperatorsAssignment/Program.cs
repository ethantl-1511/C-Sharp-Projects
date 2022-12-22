using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Individual1 = new Employee(); // instantiate two objects
            Employee Individual2 = new Employee(); // instantiate two objects

            Individual1.ID = 1;
            Individual1.FirstName = "John";
            Individual1.LastName = "Doe";
            Individual2.ID = 2;
            Individual2.FirstName = "Jane";
            Individual2.LastName = "Pro";

            Console.WriteLine("Is Individual 1's ID == to Individual 2's? " + (Individual1.ID == Individual2.ID)); // Should return False
            Console.WriteLine("Is Individual 1's ID != to Individual 2's? " + (Individual1.ID != Individual2.ID)); // Should return True

            Console.ReadLine();
        }
    }
}

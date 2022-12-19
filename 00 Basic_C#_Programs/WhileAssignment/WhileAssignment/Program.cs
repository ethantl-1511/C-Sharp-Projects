using System;

namespace WhileAssignment
{
    class Program
    {
        static void Main()
        {
            // while loop, count from 0 to 4
            int count = 0;
            while (count <= 5) // loop while count is less than or equal to 5
            {
                Console.WriteLine(count);
                count++; // +1 to count every loop
            }

            // do-while loop, countdown from 10 to 0
            int countdown = 10;
            do
            {
                Console.WriteLine(countdown);
                countdown--; // -1 to countdown every loop
            }
            while (countdown >= 0); // loop while countdown is greater than or equal to 0
            Console.Read();
        }
    }
}

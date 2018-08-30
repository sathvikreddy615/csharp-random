using System;
using System.Linq;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            Random random = new Random();
            
            // Create a list

            List<int> RandomNumberList = new List<int>();
            
            // Populate the list

            for (var i = 0; i < 10; i++) {
                int intGenerator = random.Next(51);
                RandomNumberList.Add(intGenerator);
            }

            // foreach (var number in RandomNumberList)
            // {
            //     Console.WriteLine(number);
            // }

            // 2. With the resulting List, populate a new List that contains each number squared. ----->

            List<double> RandomNumberListSquared = new List<double>();

            foreach (var number in RandomNumberList)
            {
                RandomNumberListSquared.Add(Math.Pow(number, 2));
            }
            
            foreach (var squaredInteger in RandomNumberListSquared)
            {
                Console.WriteLine(squaredInteger);  
            }

            // 3. Then remove any number that is odd from the list of squared numbers. ----->
            
            IEnumerable<double> removeOddNumbers = from number in RandomNumberListSquared
            where number % 2 == 0
            select number;

            foreach (int evenNumbers in removeOddNumbers)
            {
                Console.WriteLine(evenNumbers);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Collections_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var number = rnd.Next(0, 31);

            int[] scores = new int[10];
            for (int i = 0; i < 10; i++)
            {
                scores[i] = number;
            }

            var totalscore = 0;
            foreach(var nbr in scores)
            {
                totalscore += nbr;
            }
            Console.WriteLine($"Total bowling score is {totalscore}.");
            
            //var listOfNumbers = new List<int>();
            //listOfNumbers.Add(98);
            //listOfNumbers.Add(7);
            //listOfNumbers.Add(56);
            //listOfNumbers.Add(13);
            //listOfNumbers.Add(72);
            //listOfNumbers.Add(42);
            //listOfNumbers.Add(44);

            //var sum = 0;
            //foreach(var nbr in listOfNumbers)
            //{
            //    sum += nbr; //the same thing as sum = sum + nbr
            //}
            //Console.WriteLine($"Sum is {sum}.");
        }
    }
}

using FizzBuzz.Solutions;
using System;

namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main()
        {
            Context context = new Context();

            //demo solution
            //context.SetSolution(new Demo(2, 100));
            

            //simple solution
            //context.SetSolution(new SimpleSolution(2, 1000));

            //Tom Scotts Solution
            context.SetSolution(new TomsSolution(2, 1000));
            
            context.StartSolution();

            Console.ReadKey();

        }
    }
}
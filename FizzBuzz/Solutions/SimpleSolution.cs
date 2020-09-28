using System;

namespace FizzBuzz.Solutions
{
    internal class SimpleSolution : IFizzBuzz
    {
        const string DESCRIPTION = "Simple working solution with loops";
        public SimpleSolution()
        {
            _Description = DESCRIPTION;
        }
        public SimpleSolution(int repeat, int range) : base(repeat, range)
        {
            _Description = DESCRIPTION;
        }

        public override void Start()
        {
            for (int i = 0; i < _repeat; i++)
            {
                for (int n = 1; n <= _range; n++)
                {
                    if (CheckFizzBuzz(n))
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (CheckFizz(n))
                        Console.WriteLine("Fizz");
                    else if (CheckBuzz(n))
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(n);
                }
            }
        }

        public override void Start(int repeat, int range)
        {
            _repeat = repeat;
            _range = range;

            Start();
        }
    }
}
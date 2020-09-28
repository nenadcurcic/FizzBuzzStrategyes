using System;

namespace FizzBuzz.Solutions
{
    internal class TomsSolution : IFizzBuzz
    {
        private const string DESCRIPTION = "Toms Scott solution from youtube";

        public TomsSolution()
        {
            _Description = DESCRIPTION;
        }

        public TomsSolution(int repeat, int range) : base(repeat, range)
        {
            _Description = DESCRIPTION;
        }

        public override void Start(int repeat, int range)
        {
            _repeat = repeat;
            _range = range;

            Start();
        }

        public override void Start()
        {
            string toPrint;
            for (int i = 0; i < _repeat; i++)
            {
                for (int n = 1; n <= _range; n++)
                {
                    toPrint = CheckFizz(n) ? "Fizz" : string.Empty;
                    toPrint += CheckBuzz(n) ? "Buzz" : string.Empty;

                    if (string.IsNullOrEmpty(toPrint))
                    {
                        toPrint = n.ToString();
                    }

                    Console.WriteLine(toPrint);
                }
            }
        }
    }
}
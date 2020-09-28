using System;

namespace FizzBuzz.Solutions
{
    internal class Demo : IFizzBuzz
    {
        private const string DESCRIPTION = "Demo solution.";

        public Demo()
        {
            _Description = DESCRIPTION;
        }

        public Demo(int repeat, int range) : base(repeat, range)
        {
            _Description = DESCRIPTION;
        }

        override public void Start(int repeat, int range)
        {
            _repeat = repeat;
            _range = range;

            Start();
        }

        override public void Start()
        {
            Console.WriteLine("1");
        }
    }
}
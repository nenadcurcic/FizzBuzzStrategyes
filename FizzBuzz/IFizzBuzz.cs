namespace FizzBuzz
{
    public abstract class IFizzBuzz
    {
        protected string _Description;
        protected int _repeat;
        protected int _range;

        public double repeat
        {
            get
            {
                return _repeat;
            }
        }

        public IFizzBuzz()
        {
            _repeat = 1;
            _range = 100;
        }

        public IFizzBuzz(int repeat, int range)
        {
            _repeat = repeat;
            _range = range;
        }

        /// <summary>
        /// Start solution
        /// </summary>
        /// <param name="repeat">Number of times to repeat.</param>
        /// <param name="range">Upper limit of numbers.</param>
        /// <returns>Average time.</returns>
        abstract public void Start(int repeat, int range);

        /// <summary>
        /// Start solution with current params.
        /// </summary>
        /// <returns>Average time.</returns>
        abstract public void Start();

        /// <summary>
        /// Gets short solution description.
        /// </summary>
        /// <returns>Description</returns>
        public void PrintDescription() => System.Console.WriteLine(CreateDescription());

        protected string CreateDescription()
        {
            return $"\n{_Description} \nrepeat: {_repeat}\nrange: {_range}\n";
        }

        protected bool CheckFizz(int n) => n % 3 == 0;

        protected bool CheckBuzz(int n) => n % 5 == 0;

        protected bool CheckFizzBuzz(int n) => CheckFizz(n) && CheckBuzz(n);
    }
}
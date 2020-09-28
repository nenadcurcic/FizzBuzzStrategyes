using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace FizzBuzz
{
    internal class Context
    {
        private IFizzBuzz _fizzBuzzSolution;
        private Stopwatch _stopWatch;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Context()
        {
            _stopWatch = new Stopwatch();
        }

        /// <summary>
        /// Constructor for new solution.
        /// </summary>
        /// <param name="solution">Solution.</param>
        public Context(IFizzBuzz solution)
        {
            _fizzBuzzSolution = solution;
            _stopWatch = new Stopwatch();
        }

        /// <summary>
        /// Changing current solution in context.
        /// </summary>
        /// <param name="solution">New solution to set context.</param>
        public void SetSolution(IFizzBuzz solution)
        {
            _fizzBuzzSolution = solution;
            _stopWatch.Reset();
        }

        /// <summary>
        /// Starting solution with custom params.
        /// </summary>
        /// <param name="repeat">Number of repeating fuzzbuzz</param>
        /// <param name="range">Limit for one loop.</param>
        /// <param name="displaySteps">Displaying steps.</param>
        public void StartSolution(int repeat, int range, bool displaySteps)
        {
            _stopWatch.Start();
            _fizzBuzzSolution.Start(repeat, range);

            _stopWatch.Stop();
            _fizzBuzzSolution.PrintDescription();
            TimeSpan ts = _stopWatch.Elapsed;
            _stopWatch.Reset();

            Console.WriteLine($"Total time: { ts.TotalMilliseconds}\nAverage time: { ts.TotalMilliseconds / _fizzBuzzSolution.repeat}");
        }

        /// <summary>
        /// Starting solution with default params.
        /// </summary>
        public void StartSolution()
        {
            _stopWatch.Start();
            _fizzBuzzSolution.Start();

            _stopWatch.Stop();
            _fizzBuzzSolution.PrintDescription();
            
            TimeSpan ts = _stopWatch.Elapsed;
            _stopWatch.Reset();

            Console.WriteLine($"Total time: {ts.TotalMilliseconds}\nAverage time: {ts.TotalMilliseconds / _fizzBuzzSolution.repeat}");
        }

    }
}
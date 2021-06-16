using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzNormalAndUltra
{
    class Program
    {
        private readonly string FIZZ = "Fizz";
        private readonly string BUZZ = "Buzz";
        private readonly string FIZZBUZZ = "FizzBuzz";
        static void Main(string[] args)
        {
            Program p = new Program();
            var input = 100000;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //p.DoFizzBuzz(input);
            //p.FizzBuzz(input);
            //p.fizzBuzzAgain(input);
            //p.FizzBuzzNoLoop(input);
            //p.FizzBuzzParallel(input);
            stopwatch.Stop();
            Console.WriteLine($"Time taken {stopwatch.ElapsedMilliseconds} miliseconds for {input} nos");
            stopwatch.Reset();
        }

        public void DoFizzBuzz(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        public void FizzBuzz(int value)
        {
            int i = 0;
            while (i < value)
            {
                Console.WriteLine(++i);
                Console.WriteLine(++i);
                Console.WriteLine(FIZZ); ++i;
                Console.WriteLine(++i);
                Console.WriteLine(BUZZ); ++i;
                Console.WriteLine(FIZZ); ++i;
                Console.WriteLine(++i);
                Console.WriteLine(++i);
                Console.WriteLine(FIZZ); ++i;
                Console.WriteLine(BUZZ); ++i;
                Console.WriteLine(++i);
                Console.WriteLine(FIZZ); ++i;
                Console.WriteLine(++i);
                Console.WriteLine(++i);
                Console.WriteLine(FIZZBUZZ); ++i;
            }
        }


        public void FizzBuzzAgain(int n)
        {
            for (int i = 1, fizz = 3, buzz = 5; i <= n; i++)
            {
                if (i == fizz && i == buzz)
                {
                    Console.WriteLine("FizzBuzz");
                    fizz += 3;
                    buzz += 5;
                }
                else if (i == fizz)
                {
                    Console.WriteLine("Fizz");
                    fizz += 3;
                }
                else if (i == buzz)
                {
                    Console.WriteLine("Buzz");
                    buzz += 5;
                }
                else
                    Console.WriteLine(i);
            }
        }

        public void FizzBuzzShort(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i % 15 == 0 ? FIZZBUZZ : (i % 3 == 0 ? FIZZ : (i % 5 == 0 ? BUZZ : i.ToString())));
            }
        }

        public void FizzBuzzParallel(int val)
        {
            ParallelOptions options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 10
            };
            Parallel.ForEach(Enumerable.Range(1, val), options, (i) =>
            {
                Console.WriteLine("{0}", i % 15 == 0 ? FIZZBUZZ : (i % 3 == 0 ? FIZZ : (i % 5 == 0 ? BUZZ : i.ToString())));
            });
        }
    }
}

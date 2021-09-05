using System;
using System.Diagnostics;
using System.Threading;


namespace StopWatch
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        static void Start()
        {
            Console.WriteLine("Press 1 to start the StopWatch");
            int res = int.Parse(Console.ReadLine());

            if (res == 1)
            {
                stopwatch.Start();
            }
            
        }
        static void Stop()
        {
            Console.WriteLine("Press 0 to stop the StopWatch");
            int rev = int.Parse(Console.ReadLine());
            while (rev > 0)
            {
                Thread.Sleep(rev);
                rev++;
            }
        }

        static void Main(string[] args)
        {
            Start();
            Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

        }
    }
}

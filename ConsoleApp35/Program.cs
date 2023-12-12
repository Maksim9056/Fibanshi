using System.Diagnostics;

namespace ConsoleApp35
{
    using System;

    using System.Diagnostics;

    using System.Threading;

    class Program
    {

        public static long Fibonachi(int n)

        {

            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);

        }


        
        public static long Fibonachi2(int n)
        {
            long result = 0;
            long b = 1;

            long tmp;

            for (int i = 0; i < n; i++)
            {

                tmp = result;

                result = b;

                b += tmp;

            }
            return result;
        }


        //public static long Fibonachi3(int n)
        //{





        //    for (int i = 0; i < n; i++)
        //    {


        //        if( n == )
        //        {

        //        }
        //    }

        //    do
        //    {

        //    } while (n ==);
        //}



        public static void Main(string[] args)
        {

            long n = 900000;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            long fib4 = Fibonachi(51);

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"4th Fibonachi element = {fib4}");

            Console.WriteLine($" Elapsed time of execution = {elapsedMs}");


            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            long fib41 = Fibonachi2(9000000);

            stopwatch.Stop();

            TimeSpan executionTime = stopwatch.Elapsed;

            Console.WriteLine($"{n} th Fibonachi element = {fib41}");

            Console.WriteLine("Время выполнения кода: " + executionTime.TotalMilliseconds + " секунд");
            Console.ReadLine();
        }

    }
}

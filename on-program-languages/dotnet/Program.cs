using System;

namespace euler_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // var watch = new System.Diagnostics.Stopwatch();
            // watch.Start();

            int max = 10000000;
            Int64 sum = 0;
            for(int i=0; i < max; i++)
            {
                if(((i % 3)==0)||((i % 5)==0))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum.ToString());

            // watch.Stop();

            // Console.WriteLine($"{watch.ElapsedTicks}");
            // Console.WriteLine($"Ticks per second {System.Diagnostics.Stopwatch.Frequency}");
            // var nanosPerTick =  (1000L*1000L*1000L) / System.Diagnostics.Stopwatch.Frequency;
            // Console.WriteLine($"nanoseconds per Tick {nanosPerTick}");
            // var intervalInSecs = ( ((decimal)watch.ElapsedTicks) / ((decimal)System.Diagnostics.Stopwatch.Frequency) );
            // Console.WriteLine($"Interval in seconds {intervalInSecs}");
        }
    }
}
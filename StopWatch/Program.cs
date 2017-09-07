using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Stopwatch commands:\ns - start/stop\nq - quit");

            while (true)
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "s":
                        var timeElapsed = stopwatch.StartStop();
                        var status = (stopwatch.Status == Stopwatch.State.Stopped) ? "Stopped" : "Started";
                        Console.WriteLine("{0} at {1:hh}:{1:mm}:{1:ss}.{1:fff}", status, timeElapsed);
                        break;

                    case "q":
                        return;

                    default:
                        Console.WriteLine("Not a valid entry");
                        break;
                }
            }

        }
    }
}

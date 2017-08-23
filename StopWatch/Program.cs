using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        var status = stopwatch.Status == "stopped" ? "Stopped" : "Started";
                        Console.WriteLine("{0} at {1:hh}:{1:mm}:{1:ss}", status, timeElapsed);
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

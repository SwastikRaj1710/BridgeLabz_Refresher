using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace LogicalPrograms
{
    internal class Timer
    {
        public void FindElapsedTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Stopwatch started, enter E to stop");
            char command = Convert.ToChar(Console.ReadLine());
            while(true)
            {
                if (command == 'E')
                {
                    stopWatch.Stop();
                    break;
                }
            }
            TimeSpan totalTime = stopWatch.Elapsed;
            Console.WriteLine("Total time elapsed: " + totalTime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var startTime = StopWatch.Start();

                System.Console.WriteLine("Start Time : " + startTime);

               Thread.Sleep(60000);
                var endTime = StopWatch.Stop();

                System.Console.WriteLine("End Time : " + endTime);

                
            
            
        }
    }
}

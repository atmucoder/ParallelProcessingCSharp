using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessingCSharp
{
    public class TaskExampleOne
    {
        public static async Task ExampleOne()
        {
            Task task = new Task(() => { for (int i = 0; i < 10000; i++) { Console.WriteLine(i); } });
            task.Start();
            await Task.Delay(2000); //wait for few seconds to see partial output from above task.
            Console.WriteLine("Main method ends without waiting for the task to end");
        }
    }
}

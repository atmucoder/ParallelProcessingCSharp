using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessingCSharp
{
    public class TaskExampleTwo
    {
        public static async Task ExampleTwo()
        {
            Task task = Task.Run(() => { for (int i = 0; i < 10000; i++) { Console.WriteLine(i); } });
            task.Wait();
            Console.WriteLine("Main method waits for the task to end");
        }
    }
}

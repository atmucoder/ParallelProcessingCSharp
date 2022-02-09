using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ParallelProcessingCSharp
{
    public class TaskExampleFive
    {
        public static async Task ExampleFive()
        {
            //example of chaining of tasks
            Task<List<int>> task1 = Task.Factory.StartNew(() => { var list = new List<int>(); for (int i = 0; i < 10; i++) { list.Add(i); } return list; });
            Task task2 = task1.ContinueWith((x) => { foreach (int var in x.Result ) { Console.WriteLine(var); } });
            task2.Wait();
        }
    }
}

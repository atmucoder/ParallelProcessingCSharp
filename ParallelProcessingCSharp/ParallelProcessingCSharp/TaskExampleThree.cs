using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessingCSharp
{
    public class TaskExampleThree
    {
        public static async Task ExampleThree()
        {
            Task parent = Task.Factory.StartNew(() => { Console.WriteLine("writing from parent task"); Task child = Task.Factory.StartNew(() => { for (int i = 0; i < 10; i++) { Console.WriteLine("writing from child task"); } }); });
            parent.Wait();//since child is a detached task, main thread wont wait for it and hence its output will be partially visible
        }
    }
}

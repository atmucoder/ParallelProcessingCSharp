using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessingCSharp
{
    public class TaskExampleFour
    {
        public static async Task ExampleFour()
        {
            //same as example three except that we create a attached child task and so its output is also visible
            Task parent = Task.Factory.StartNew(() => { Console.WriteLine("writing from parent task"); Task child = Task.Factory.StartNew(() => { for (int i = 0; i < 10; i++) { Console.WriteLine("writing from child task"); } },TaskCreationOptions.AttachedToParent); });
            parent.Wait();//since child is an attached task, main thread will wait for it and hence its output will be completely visible
        }
    }
}

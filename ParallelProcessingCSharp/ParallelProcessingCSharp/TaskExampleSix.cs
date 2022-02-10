using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessingCSharp
{
    public class TaskExampleSix
    {
        public static async Task ExampleSix()
        {
            //example of continuation from multiple antecedents
            var tasks = new List<Task<int>>();
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int baseValue = ctr;
                tasks.Add(Task.Factory.StartNew(b => (int)b * (int)b, baseValue));
            }

            var results = await Task.WhenAll(tasks); //or TaskFactory.ContinueWhenAll

            int sum = 0;
            for (int ctr = 0; ctr <= results.Length - 1; ctr++)
            {
                var result = results[ctr];
                Console.Write($"{result} {((ctr == results.Length - 1) ? "=" : "+")} ");
                sum += result;
            }

            Console.WriteLine(sum);
        }
    }
}

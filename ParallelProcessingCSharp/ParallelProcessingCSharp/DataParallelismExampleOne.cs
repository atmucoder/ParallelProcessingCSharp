using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProcessingCSharp
{
    public class DataParallelismExampleOne
    {
        public static string directoryName = @"C:/Users/atharvam/repos/ParallelProcessingCSharp/ParallelProcessingCSharp/ParallelProcessingCSharp";

        public static void ExampleOne(string[] args)
        {
            long totalSize = 0;

            if (!Directory.Exists(directoryName))
            {
                Console.WriteLine("The directory does not exist.");
                return;
            }

            String[] files = Directory.GetFiles(directoryName);
            Parallel.For(0, files.Length,
                         index => {
                             FileInfo fi = new FileInfo(files[index]);
                             long size = fi.Length;
                             Interlocked.Add(ref totalSize, size);
                         });
            Console.WriteLine("Directory '{0}':", directoryName);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }
    }
}

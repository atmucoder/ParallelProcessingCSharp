using System;

namespace ParallelProcessingCSharp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataParallelismExampleOne.ExampleOne(new String[1]);
            DataParallelismExampleTwo.ExampleTwo(new String[1]);
            DataParallelismExampleThree.ExampleThree();
            DataParallelismExampleFour.ExampleFour();
            DataParallelismExampleFive.ExampleFive();
            //DataParallelismExampleSix.ExampleSix(new string[1]);
        }
    }
}
using System;

namespace lowq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from lowq");
            CalculateClass cs = new CalculateClass();
            Console.WriteLine("SumOf8() is:" + cs.SumOf8(1,2,3,4,5,6,7,8));
        }
    }
}

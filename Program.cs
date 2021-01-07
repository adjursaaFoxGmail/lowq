using System;

namespace lowq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from lowq");
            CalculateClass cs = new CalculateClass();
            Console.WriteLine("SumOf9() is:" + cs.SumOf9(1,2,3,4,5,6,7,8,9));
        }
    }
}

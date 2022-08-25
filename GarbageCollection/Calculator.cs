using System;

namespace GarbageCollection
{
    internal class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}

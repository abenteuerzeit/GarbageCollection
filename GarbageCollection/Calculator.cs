using System;

namespace GarbageCollection
{
    internal class Calculator : IDisposable
    {
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("Calculator being disposed");
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}

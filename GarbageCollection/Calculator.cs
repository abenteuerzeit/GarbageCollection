using System;

namespace GarbageCollection
{
    internal class Calculator : IDisposable
    {
        private bool disposed = false;
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
            lock (this)
            {
                if (!this.disposed)
                {
                    Console.WriteLine("Calculator being disposed");
                }
                this.disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}

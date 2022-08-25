using System;

namespace GarbageCollection
{
    class Program
    {
        static void doWork()
        {
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");
            }
            Console.WriteLine("Program finishing");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintManagerDetails(),
                () => PrintHRdetails()
                );
            Console.ReadLine();
        }
        private static void PrintManagerDetails()
        {
            Printer fromManager = Printer.GetInstance;
            fromManager.PrintDetails("From Manager");
        }
        private static void PrintHRdetails()
        {
            Printer fromHr = Printer.GetInstance;
            fromHr.PrintDetails("From Hr");
        }

    }
}

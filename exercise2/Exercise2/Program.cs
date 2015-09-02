using System;
using System.Threading;

// Heavily inspired by https://www.youtube.com/watch?v=6_GTdR0gBVE
namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Starting");

            var worker = new Worker();
            worker.DoWork();

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void ReportProgress(Worker worker)
        {
            while (!worker.IsComplete)
            {
                Console.Write('.');
                Thread.Sleep(100);
            }
        }
    }
}

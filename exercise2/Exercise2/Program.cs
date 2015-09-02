using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

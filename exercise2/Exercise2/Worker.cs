using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise2 {
    class Worker {
        public bool IsComplete { get; private set; }

        public void DoWork()
        {
            IsComplete = false;
            LongOperation();
            IsComplete = true;
        }

        private void LongOperation()
        {
            Console.WriteLine("Working...");
            Thread.Sleep(3000);
        }
    }
}

using System;
using System.Threading;

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

using System;
using System.Threading;

namespace Exercise2 {
    class Worker {
        public bool IsComplete { get; private set; }

        public async void DoWork()
        {
            IsComplete = false;
            await LongOperation();
            IsComplete = true;
        }

        private async Task LongOperation()
        {
            Console.WriteLine("Working...");
            await Task.Delay(3000);
        }
    }
}

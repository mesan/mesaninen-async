using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

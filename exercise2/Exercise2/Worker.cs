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

        private Task LongOperation()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Working...");
                Thread.Sleep(3000);
            });
        }
    }
}

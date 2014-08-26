using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            textBox.Text = await DoWork();
            Cursor = DefaultCursor;
        }

        private Task<string> DoWork()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(3000);
                return "Async and await rocks!";
            });
        }
    }
}

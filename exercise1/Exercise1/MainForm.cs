using System;
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
            textBox.Text = DoWork().Result;
            Cursor = DefaultCursor;
        }

        private async Task<string> DoWork()
        {
            Task.Delay(3000);
            return "Await-ing more code here";
        }
    }
}

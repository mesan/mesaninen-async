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
            textBox.Text = await DoWork();
            Cursor = DefaultCursor;
        }

        private async Task<string> DoWork()
        {
            await Task.Delay(3000);
            return "Async and await rocks!";
        }
    }
}

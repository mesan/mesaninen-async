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

        private void startButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            textBox.Text = DoWork();
            Cursor = DefaultCursor;
        }

        private string DoWork()
        {
            return "Await-ing more code here";
        }
    }
}

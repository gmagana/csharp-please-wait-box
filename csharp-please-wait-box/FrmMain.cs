using System;
using System.Threading;
using System.Windows.Forms;

namespace csharp_please_wait_box {
    public partial class FrmMain : Form {
        public FrmMain() {
            this.InitializeComponent();
        }

        /// <summary>
        /// Shows how to call the please wait form for a background process without UI interaction
        /// </summary>
        private void BtnExample1_Click(object sender, EventArgs e) {
            using (var frm = new FrmPleaseWait(this, () => {
                for (var i = 1; i <= 5; i++) {
                    Thread.Sleep(1000);
                }
            })) {
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Shows how to call the lease wait form for a background process with UI interaction
        /// </summary>
        private void BtnExample2_Click(object sender, EventArgs e) {
            this.textBox1.Text = "";
            Application.DoEvents();

            using (var frm = new FrmPleaseWait(this, () => {
                for (var i = 1; i <= 5; i++) {
                    Thread.Sleep(1000);

                    // We must cause the code that updates the UI to execute on the main thread
                    this.textBox1.Invoke((MethodInvoker) (() => {
                        this.textBox1.Text += $"{i} Seconds\r\n";
                    }));
                }
            })) {
                frm.ShowDialog();
            }
        }
    }
}

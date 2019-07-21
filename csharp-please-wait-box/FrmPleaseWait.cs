using System;
using System.Threading;
using System.Windows.Forms;

namespace csharp_please_wait_box {
    public partial class FrmPleaseWait : Form {
        private readonly MethodInvoker method;

        public FrmPleaseWait(Form owner, MethodInvoker action) {
            this.InitializeComponent();

            this.method = action;
            this.Owner = owner;
        }

        private void FrmPleaseWait_Shown(object sender, EventArgs e) {
            // Call DoEvents so that this form finishes painting before we execute the background code
            Application.DoEvents();

            // Create a new thread to execute background code
            new Thread(() => {
                // Execute action that was passed to us
                this.method.Invoke();

                // Close and dispose of this form
                if (this.InvokeRequired) {
                    this.BeginInvoke((MethodInvoker) this.Dispose);
                } else {
                    this.Dispose();
                }
            }).Start();
        }

        private void FrmPleaseWait_FormClosing(object sender, FormClosingEventArgs e) {
            // Prevent form close if user clicks the X button
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
            }
        }
    }
}

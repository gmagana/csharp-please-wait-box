namespace csharp_please_wait_box {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(22, 12);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(166, 60);
            this.btnExample1.TabIndex = 0;
            this.btnExample1.Text = "Start Long Process (No UI Updates)";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.BtnExample1_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(22, 78);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(166, 60);
            this.btnExample2.TabIndex = 1;
            this.btnExample2.Text = "Start Long Process (With UI Updates)";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.BtnExample2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 224);
            this.textBox1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 536);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExample2);
            this.Controls.Add(this.btnExample1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


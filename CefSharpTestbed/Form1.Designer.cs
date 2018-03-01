namespace CefSharpTestbed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCefSharp = new System.Windows.Forms.Panel();
            this.btnChromeDevTools = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlCefSharp
            // 
            this.pnlCefSharp.Location = new System.Drawing.Point(10, 38);
            this.pnlCefSharp.Name = "pnlCefSharp";
            this.pnlCefSharp.Size = new System.Drawing.Size(1024, 768);
            this.pnlCefSharp.TabIndex = 0;
            // 
            // btnChromeDevTools
            // 
            this.btnChromeDevTools.Location = new System.Drawing.Point(13, 5);
            this.btnChromeDevTools.Name = "btnChromeDevTools";
            this.btnChromeDevTools.Size = new System.Drawing.Size(129, 23);
            this.btnChromeDevTools.TabIndex = 1;
            this.btnChromeDevTools.Text = "Chrome Dev Tools";
            this.btnChromeDevTools.UseVisualStyleBackColor = true;
            this.btnChromeDevTools.Click += new System.EventHandler(this.btnChromeDevTools_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 818);
            this.Controls.Add(this.btnChromeDevTools);
            this.Controls.Add(this.pnlCefSharp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCefSharp;
        private System.Windows.Forms.Button btnChromeDevTools;
    }
}


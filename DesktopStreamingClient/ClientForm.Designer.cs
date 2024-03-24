namespace DesktopStreamingClient
{
    partial class ClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logTextBox = new TextBox();
            connectButton = new Button();
            startStreamingButton = new Button();
            SuspendLayout();
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Top;
            logTextBox.Location = new Point(0, 0);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(382, 120);
            logTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            connectButton.Dock = DockStyle.Left;
            connectButton.Location = new Point(0, 120);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(199, 33);
            connectButton.TabIndex = 1;
            connectButton.Text = "CONNECT TO SERVER";
            connectButton.UseVisualStyleBackColor = true;
            // 
            // startStreamingButton
            // 
            startStreamingButton.Dock = DockStyle.Fill;
            startStreamingButton.Location = new Point(199, 120);
            startStreamingButton.Name = "startStreamingButton";
            startStreamingButton.Size = new Size(183, 33);
            startStreamingButton.TabIndex = 2;
            startStreamingButton.Text = "START STREAMING";
            startStreamingButton.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 153);
            Controls.Add(startStreamingButton);
            Controls.Add(connectButton);
            Controls.Add(logTextBox);
            Name = "ClientForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logTextBox;
        private Button connectButton;
        private Button startStreamingButton;
    }
}

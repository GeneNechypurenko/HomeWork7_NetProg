namespace DesktopStreamingServer
{
    partial class ServerForm
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
            panel1 = new Panel();
            pictureBox = new PictureBox();
            panel2 = new Panel();
            startServerButton = new Button();
            logTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 325);
            panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(800, 325);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(startServerButton);
            panel2.Controls.Add(logTextBox);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 325);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 125);
            panel2.TabIndex = 1;
            // 
            // startServerButton
            // 
            startServerButton.Dock = DockStyle.Bottom;
            startServerButton.Location = new Point(0, 96);
            startServerButton.Name = "startServerButton";
            startServerButton.Size = new Size(800, 29);
            startServerButton.TabIndex = 1;
            startServerButton.Text = "START SERVER";
            startServerButton.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Fill;
            logTextBox.Location = new Point(0, 0);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(800, 125);
            logTextBox.TabIndex = 0;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ServerForm";
            Text = "ServerForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox;
        private Panel panel2;
        private TextBox logTextBox;
        private Button startServerButton;
    }
}

using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopStreamingClient
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public ClientForm()
        {
            InitializeComponent();
            connectButton.Click += ConnectButton_Click;
            startStreamingButton.Click += StartStreamingButton_Click;
            FormClosing += ClientForm_FormClosing;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string serverIP = "127.0.0.1";
            int serverPort = 8888;

            client = new TcpClient();
            client.Connect(serverIP, serverPort);
            stream = client.GetStream();

            LogMessage("����������� � �������...");
        }

        private async void StartStreamingButton_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    Image desktopImage = CaptureDesktop();
                    byte[] imageData;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        desktopImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }

                    byte[] sizeBytes = BitConverter.GetBytes(imageData.Length);
                    await stream.WriteAsync(sizeBytes, 0, sizeBytes.Length);

                    await stream.WriteAsync(imageData, 0, imageData.Length);
                    LogMessage("����������� ���������� �� ������.");

                    await Task.Delay(50);
                }
            }
            catch (Exception ex)
            {
                LogMessage("������ ��� �������� ������ �� ������: " + ex.Message);
            }
        }

        private Image CaptureDesktop()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            Bitmap bitmap = new Bitmap(screenWidth, screenHeight);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, new Size(screenWidth, screenHeight));
            }
            return bitmap;
        }

        private void LogMessage(string message)
        {
            if (logTextBox.InvokeRequired)
            {
                logTextBox.Invoke(new MethodInvoker(delegate { LogMessage(message); }));
            }
            else
            {
                logTextBox.AppendText(message + Environment.NewLine);
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
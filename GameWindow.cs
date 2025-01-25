using System;
using System.Drawing;
using System.Windows.Forms;

namespace RebelSpace
{
    public class GameWindow : Form
    {
        private TileMap tileMap;
        private Player player;
        private string serverAddress;

        public GameWindow(string serverAddress)
        {
            this.serverAddress = serverAddress;
            this.Text = $"RebelSpace - Connected to {serverAddress}";
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true; // For smoother graphics

            // Create the "Test Dev" map with a 10x10 grid of tiles, each 50x50 pixels
            tileMap = new TileMap("Test Dev", 10, 10, 50);
            player = new Player(100, 450, 50, 50, Color.Blue, 10);

            // Add logic to connect to the server
            ConnectToServer();

            this.KeyDown += new KeyEventHandler(OnKeyDown);
        }

        private void ConnectToServer()
        {
            // Logic to connect to the server
            // Example: using sockets to establish a connection
            // In this example, it's just a message box
            MessageBox.Show($"Connected to server: {serverAddress}");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            tileMap.Draw(g);
            player.Draw(g);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.MoveLeft();
                    break;
                case Keys.Right:
                    player.MoveRight();
                    break;
            }
            Invalidate(); // Redraw the window
        }
    }
}
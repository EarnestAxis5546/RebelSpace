using System;
using System.Drawing;
using System.Windows.Forms;

namespace RebelSpace
{
    public class GameWindow : Form
    {
        private TileMap tileMap;
        private Player player;

        public GameWindow()
        {
            this.Text = "RebelSpace - Version 0.1 AL";
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true; // Для сглаживания графики

            tileMap = new TileMap();
            player = new Player(100, 450, 50, 50, Color.Blue, 10);

            this.KeyDown += new KeyEventHandler(OnKeyDown);
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
            Invalidate(); // Перерисовать окно
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameWindow());
        }
    }
}
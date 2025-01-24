using System.Drawing;

namespace RebelSpace
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public int Speed { get; set; }

        public Player(int x, int y, int width, int height, Color color, int speed)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
            Speed = speed;
        }

        public void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
        }

        public void MoveLeft() => X -= Speed;
        public void MoveRight() => X += Speed;
    }
}
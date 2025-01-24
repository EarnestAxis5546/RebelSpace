using System.Drawing;

namespace RebelSpace
{
    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        public Tile(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
        }
    }
}
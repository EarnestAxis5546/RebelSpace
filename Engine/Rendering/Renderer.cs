using System;
using System.Drawing;
using System.Windows.Forms;

public class Renderer : Form
{
    private Timer timer;
    private Bitmap canvas;

    public Renderer(int width, int height)
    {
        this.Width = width;
        this.Height = height;
        this.DoubleBuffered = true;
        this.canvas = new Bitmap(width, height);

        this.timer = new Timer();
        this.timer.Interval = 16; // Approximately 60 FPS
        this.timer.Tick += new EventHandler(OnTick);
        this.timer.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = Graphics.FromImage(canvas);
        g.Clear(Color.Black);

        // Render game objects here
        // Example:
        // g.DrawImage(playerTexture, playerPosition);

        e.Graphics.DrawImage(canvas, 0, 0);
    }

    private void OnTick(object sender, EventArgs e)
    {
        Invalidate(); // Triggers OnPaint
    }
}
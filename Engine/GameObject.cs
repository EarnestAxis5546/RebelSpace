using System.Drawing;

public class GameObject
{
    public PointF Position { get; set; }
    public PointF Velocity { get; set; }
    public Bitmap Texture { get; set; }

    public GameObject(Bitmap texture, PointF position, PointF velocity)
    {
        Texture = texture;
        Position = position;
        Velocity = velocity;
    }

    public void Update()
    {
        Position = new PointF(Position.X + Velocity.X, Position.Y + Velocity.Y);
    }
}
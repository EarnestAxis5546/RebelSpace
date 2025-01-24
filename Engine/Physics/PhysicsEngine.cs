using System.Collections.Generic;

public class PhysicsEngine
{
    public void Update(List<GameObject> gameObjects)
    {
        foreach (var gameObject in gameObjects)
        {
            // Apply physics logic here
            // Example: gameObject.Position += gameObject.Velocity;
        }
    }
}
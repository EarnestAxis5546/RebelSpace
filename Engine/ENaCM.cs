public class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<IComponent> Components { get; set; }
}

public interface IComponent { }

public class PositionComponent : IComponent
{
    public float X { get; set; }
    public float Y { get; set; }
}

public class VelocityComponent : IComponent
{
    public float X { get; set; }
    public float Y { get; set; }
}

public class SpriteComponent : IComponent
{
    public string Texture { get; set; }
}

public class VisionComponent : IComponent
{
    public float Range { get; set; }
}

public class HealthComponent : IComponent
{
    public int Health { get; set; }
}

public class InteractableComponent : IComponent
{
    public string Action { get; set; }
}

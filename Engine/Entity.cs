// File: Engine/Entity.cs
using System.Collections.Generic;

namespace RebelSpace.Engine
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IComponent> Components { get; set; }

        public Entity()
        {
            Components = new List<IComponent>();
        }
    }
}
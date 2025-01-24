using System.Collections.Generic;

public class GameManager
{
    private List<GameObject> gameObjects = new List<GameObject>();

    public void Initialize()
    {
        // Load and initialize game objects from config
        var entities = ConfigLoader.LoadEntities("Assets/Config/config.yaml");
        foreach (var entity in entities)
        {
            // Initialize game objects based on loaded entities
            // Example: gameObjects.Add(new GameObject(...));
        }
    }

    public void Update()
    {
        // Update all game objects
        foreach (var gameObject in gameObjects)
        {
            gameObject.Update();
        }
    }
}

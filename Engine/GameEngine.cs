// File: Engine/GameEngine.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RebelSpace.Engine
{
    public class GameEngine
    {
        private Renderer renderer;
        private PhysicsEngine physicsEngine;
        private List<GameObject> gameObjects;
        private string serverAddress;

        public GameEngine(string serverAddress)
        {
            this.serverAddress = serverAddress; // Сохранение адреса сервера
            this.renderer = new Renderer(800, 600);
            this.physicsEngine = new PhysicsEngine();
            this.gameObjects = new List<GameObject>();

            // Load game objects, for example:
            // Bitmap playerTexture = new Bitmap("Assets/Textures/Characters/player.png");
            // GameObject player = new GameObject(playerTexture, new PointF(100, 100), new PointF(0, 0));
            // gameObjects.Add(player);
        }

        public void Run()
        {
            // Здесь можно добавить логику подключения к серверу
            Console.WriteLine($"Connecting to server: {serverAddress}");
            Application.Run(renderer);
        }

        public void Update()
        {
            physicsEngine.Update(gameObjects);
            
            foreach (var gameObject in gameObjects)
            {
                gameObject.Update();
            }
        }
    }
}
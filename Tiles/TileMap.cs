using System.Collections.Generic;
using System.Drawing;

namespace RebelSpace
{
    public class TileMap
    {
        public string Name { get; private set; }
        private List<Tile> tiles = new List<Tile>();

        public TileMap(string name, int width, int height, int tileSize)
        {
            Name = name;
            // Create the map using tiles
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    tiles.Add(new Tile(x * tileSize, y * tileSize, tileSize, tileSize, Color.Brown));
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (var tile in tiles)
            {
                tile.Draw(g);
            }
        }
    }
}
using System.Collections.Generic;
using System.Drawing;

namespace RebelSpace
{
    public class TileMap
    {
        private List<Tile> tiles = new List<Tile>();

        public TileMap()
        {
            // Создание платформы из тайлов
            int tileSize = 50;
            for (int i = 0; i < 16; i++)
            {
                tiles.Add(new Tile(i * tileSize, 500, tileSize, tileSize, Color.Brown));
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
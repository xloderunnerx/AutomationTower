using UnityEngine;

namespace App.Features.Floor
{
	public class FloorModel
	{
		public Vector2Int size;
		public Tile[,] grid;

        public void GenerateFloor(Vector2Int size)
        {
            this.size = size;
            grid = new Tile[size.x, size.y];
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    var tile = new Tile();
                    tile.position = new Vector3Int(x, 0, z);
                    grid[x, z] = tile;
                }
            }
        }
    }
}
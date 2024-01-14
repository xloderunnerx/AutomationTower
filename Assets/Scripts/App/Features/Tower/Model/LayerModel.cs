using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Tower
{
    public class LayerModel
    {
        public int height;
        public Vector2Int size;
        public Tile[,] grid;

        public void GenerateLayer(int height, Vector2Int size)
        {
            this.height = height;
            this.size = size;
            grid = new Tile[size.x, size.y];
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    var tile = new Tile();
                    tile.gridPosition = new Vector3Int(x, height, z);
                    grid[x, z] = tile;
                }
            }
        }
    }
}

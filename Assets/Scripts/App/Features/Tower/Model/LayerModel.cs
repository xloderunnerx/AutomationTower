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
        public Vector3 worldPosition;
        public Vector2Int size;
        public TileModel[,] grid;

        public void GenerateLayer(Vector3 worldPosition, LayerConfiguration layerConfiguration)
        {
            this.worldPosition = new Vector3(worldPosition.x, worldPosition.y + worldPosition.y * layerConfiguration.betweenLayerSpacing, worldPosition.z);
            size = layerConfiguration.layerSize;
            grid = new TileModel[size.x, size.y];
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    var tile = new TileModel();
                    tile.worldPosition = new Vector3(x - size.x / 2, worldPosition.y + worldPosition.y * layerConfiguration.betweenLayerSpacing, z - size.y / 2);
                    tile.gridPosition = new Vector3Int(x, (int)worldPosition.y, z);
                    grid[x, z] = tile;
                }
            }
        }
    }
}

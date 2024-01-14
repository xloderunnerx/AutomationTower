using UnityEngine;

namespace App.Features.Structures
{
    public class LayerModel
    {
        public Vector3 worldPosition;
        public Vector2Int size;
        public TileModel[,] grid;

        public void GenerateLayer(Tower.LayerModel layerModel)
        {
            this.worldPosition = layerModel.worldPosition;
            size = layerModel.size;
            grid = new TileModel[size.x, size.y];
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.y; z++)
                {
                    var tile = new TileModel();
                    tile.worldPosition = new Vector3(x - size.x / 2, worldPosition.y + 1, z - size.y / 2);
                    tile.gridPosition = new Vector3Int(x, (int)worldPosition.y, z);
                    grid[x, z] = tile;
                }
            }
        }
    }
}

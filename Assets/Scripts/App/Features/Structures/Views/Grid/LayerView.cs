using Composite.Core;
using System.Collections.Generic;
using UnityEngine;

namespace App.Features.Structures
{
    public class LayerView : AbstractView
    {
        public List<TileView> layer;

        public void GenerateLayer(LayerModel layerModel, LayerConfiguration layerConfiguration)
        {
            for (int x = 0; x < layerModel.size.x; x++)
            {
                for (int z = 0; z < layerModel.size.y; z++)
                {
                    var tileView = GameObject.Instantiate(layerConfiguration.tileViewPrefab, transform);
                    tileView.transform.position = layerModel.grid[x, z].worldPosition;
                    tileView.gameObject.name += $" - x:{x}; y:{layerModel.worldPosition.y}; z:{z};";
                    tileView.worldPosition = layerModel.grid[x, z].worldPosition;
                    tileView.gridPosition = layerModel.grid[x, z].gridPosition;
                    layer.Add(tileView);
                }
            }
        }
    }
}

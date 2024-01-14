﻿using Composite.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Tower
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
                    tileView.SetTileColor(Color.HSVToRGB(0, 0, Random.Range(0.7f, 1.0f)));
                    tileView.worldPosition = layerModel.grid[x, z].worldPosition;
                    tileView.gridPosition = layerModel.grid[x, z].gridPosition;
                    if (x == 0 || z == 0 || x == layerModel.size.x - 1 || z == layerModel.size.y - 1)
                        tileView.SetTileColor(layerConfiguration.bordersColor + Color.HSVToRGB(0, 0, Random.Range(0.0f, 0.3f)));
                    layer.Add(tileView);
                }
            }
        }
    }
}

using Composite.Core;
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
                    tileView.transform.position = new Vector3(layerModel.grid[x, z].gridPosition.x - layerModel.size.x / 2, layerModel.height + layerModel.height * layerConfiguration.betweenLayerSpacing, layerModel.grid[x, z].gridPosition.z - layerModel.size.y / 2);
                    tileView.gameObject.name += $" - x:{x}; y:{layerModel.height}; z:{z};";
                    tileView.SetTileColor(Color.HSVToRGB(0, 0, Random.Range(0.7f, 1.0f)));
                    if (x == 0 || z == 0 || x == layerModel.size.x - 1 || z == layerModel.size.y - 1)
                        tileView.SetTileColor(layerConfiguration.bordersColor + Color.HSVToRGB(0, 0, Random.Range(0.0f, 0.3f)));
                    layer.Add(tileView);
                }
            }
        }
    }
}

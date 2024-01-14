using Composite.Core;
using UnityEngine;

namespace App.Features.Floor
{
    public class FloorController : AbstractController
    {
        private FloorView view;
        private FloorConfiguration configuration;
        private FloorModel model;

        private TileView[,] gridView;

        public FloorController(FloorView view, FloorConfiguration configuration, FloorModel model)
        {
            this.view = view;
            this.configuration = configuration;
            this.model = model;
        }

        public override void Initialize()
        {
            model.GenerateFloor(configuration.size);
            GenerateFloorView();
        }

        private void GenerateFloorView()
        {
            gridView = new TileView[model.size.x, model.size.y];
            for (int x = 0; x < model.size.x; x++)
            {
                for (int z = 0; z < model.size.y; z++)
                {
                    var tileView = GameObject.Instantiate(configuration.tileViewPrefab, view.transform);
                    tileView.transform.position = new Vector3(model.grid[x, z].position.x, 0, model.grid[x, z].position.z);
                    tileView.position = new Vector3Int(x, 0, z);
                    tileView.gameObject.name += $" - x:{x}; y:0; z:{z};";
                    tileView.SetTileColor(Color.HSVToRGB(0, 0, Random.Range(0.7f, 1.0f)));
                    gridView[x, z] = tileView;
                }
            }
        }
    }
}
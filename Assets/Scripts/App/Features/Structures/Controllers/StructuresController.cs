using App.Features.TouchRaycast;
using App.Features.Tower;
using Composite.Core;
using System;
using System.Linq;
using UnityEngine;

namespace App.Features.Structures
{
	public class StructuresController : AbstractController
	{
		private StructuresView view;
		private StructuresConfiguration configuration;
		private StructuresModel model;

        public StructuresController(StructuresView view, StructuresConfiguration configuration, StructuresModel model)
        {
            this.view = view;
            this.configuration = configuration;
            this.model = model;
        }

        public override void Initialize()
		{
		}

        public override void SubscribeToSignals()
        {
            SubscribeToSignal<LayerAddSignal>(signal => OnLayerAdd(signal));
            SubscribeToSignal<RaycastTouchDownSignal>(signal => TryBuildBox(signal));
        }

        private void TryBuildBox(RaycastTouchDownSignal signal)
        {
            if (signal.Hit.collider == null)
                return;
            var tileView = signal.Hit.collider.GetComponent<TileView>();
            if (tileView == null)
                return;
            var tileModel = model.layers.Where(layer => layer.worldPosition.y == tileView.gridPosition.y).FirstOrDefault().grid[tileView.gridPosition.x, tileView.gridPosition.z];
            if (tileModel.isOccupied)
                return;
            tileModel.isOccupied = true;
            var boxModel = new BoxModel(tileView.worldPosition, tileView.gridPosition);
            model.strauctures.Add(boxModel);
            var boxView = GameObject.Instantiate(configuration.boxViewPrefab, view.transform);
            boxView.transform.position = boxModel.worldPosition;
            boxView.gridPosition = boxModel.gridPosition;
            view.abstractStructureViews.Add(boxView);
        }

        private void OnLayerAdd(LayerAddSignal signal)
        {
            var layerModel = AddLayerModel(signal.LayerModel);
            model.layers.Add(layerModel);
            var layerView = AddLayerView(layerModel);
            view.layerViews.Add(layerView);
        }

        private LayerModel AddLayerModel(Tower.LayerModel layerModel)
        {
            var newLayerModel = new LayerModel();
            newLayerModel.GenerateLayer(layerModel);
            return newLayerModel;
        }

        private LayerView AddLayerView(LayerModel layerModel)
        {
            var layerView = GameObject.Instantiate(configuration.layerViewPrefab, view.transform);
            layerView.transform.position = layerModel.worldPosition;
            layerView.GenerateLayer(layerModel, configuration.layerConfiguration);
            layerView.gameObject.name += $" - height: {layerModel.worldPosition.y}";
            return layerView;
        }
    }
}
using App.Features.TouchRaycast;
using App.Features.Tower;
using Composite.Core;
using System;
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
            return layerView;
        }
    }
}
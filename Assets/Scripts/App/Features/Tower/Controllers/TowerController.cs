using Composite.Core;
using System.Collections.Generic;
using UnityEngine;

namespace App.Features.Tower
{
    public class TowerController : AbstractController, IUpdatable
    {
        private TowerView view;
        private TowerConfiguration configuration;
        private TowerModel model;

        public TowerController(TowerView view, TowerConfiguration configuration, TowerModel model)
        {
            this.view = view;
            this.configuration = configuration;
            this.model = model;
        }

        public override void DeclareSignals()
        {
            DeclareSignal<OnLayerAdd>();
        }

        public override void Initialize()
        {

        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                var layerModel = AddLayerModel(model.tower.Count, new Vector2Int(configuration.layerConfiguration.layerSize.x, configuration.layerConfiguration.layerSize.y));
                model.tower.Add(layerModel);
                var layerView = AddLayerView(layerModel);
                view.tower.Add(layerView);
            }
        }

        private LayerModel AddLayerModel(int height, Vector2Int size)
        {
            var layerModel = new LayerModel();
            layerModel.GenerateLayer(height, new Vector2Int(size.x, size.y));
            return layerModel;
        }

        private LayerView AddLayerView(LayerModel layerModel)
        {
            var layerView = GameObject.Instantiate(configuration.layerViewPrefab, view.transform);
            layerView.transform.position = new Vector3(0, layerModel.height + layerModel.height * configuration.layerConfiguration.betweenLayerSpacing, 0);
            layerView.GenerateLayer(layerModel, configuration.layerConfiguration);
            return layerView;
        }
    }
}
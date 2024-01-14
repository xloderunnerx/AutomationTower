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
            DeclareSignal<LayerAddSignal>();
        }

        public override void Initialize()
        {

        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
                AddLayer();
        }

        private void AddLayer()
        {
            var layerModel = AddLayerModel(new Vector3(0, model.tower.Count, 0), new Vector2Int(configuration.layerConfiguration.layerSize.x, configuration.layerConfiguration.layerSize.y));
            model.tower.Add(layerModel);
            var layerView = AddLayerView(layerModel);
            view.tower.Add(layerView);
            TryFireSignal(new LayerAddSignal(layerModel));
        }

        private LayerModel AddLayerModel(Vector3 position, Vector2Int size)
        {
            var layerModel = new LayerModel();
            layerModel.GenerateLayer(position, configuration.layerConfiguration);
            return layerModel;
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
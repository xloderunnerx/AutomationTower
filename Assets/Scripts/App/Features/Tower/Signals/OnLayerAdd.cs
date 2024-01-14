using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Features.Tower
{
    public class OnLayerAdd
    {
        private LayerModel layerModel;

        public OnLayerAdd(LayerModel layerModel)
        {
            this.layerModel = layerModel;
        }

        public LayerModel LayerModel { get => layerModel; private set => layerModel = value; }
    }
}

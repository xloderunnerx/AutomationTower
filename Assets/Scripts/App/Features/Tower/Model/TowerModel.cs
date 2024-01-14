using System.Collections.Generic;

namespace App.Features.Tower
{
	public class TowerModel
	{
		public List<LayerModel> tower;

        public TowerModel()
        {
            this.tower = new List<LayerModel>();
        }
    }
}
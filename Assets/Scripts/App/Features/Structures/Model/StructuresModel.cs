using System.Collections.Generic;

namespace App.Features.Structures
{
	public class StructuresModel
	{
		public List<LayerModel> layers;

        public StructuresModel()
        {
            this.layers = new List<LayerModel>();
        }
    }
}
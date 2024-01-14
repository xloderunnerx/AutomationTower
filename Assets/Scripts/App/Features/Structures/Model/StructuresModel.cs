using System.Collections.Generic;

namespace App.Features.Structures
{
	public class StructuresModel
	{
		public List<LayerModel> layers;
        public List<AbstractStructureModel> strauctures;

        public StructuresModel()
        {
            layers = new List<LayerModel>();
            strauctures = new List<AbstractStructureModel>();
        }
    }
}
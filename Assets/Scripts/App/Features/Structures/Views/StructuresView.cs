using Composite.Core;
using System.Collections.Generic;
using UnityEngine;

namespace App.Features.Structures
{
	public class StructuresView : AbstractView
	{
		public List<LayerView> layerViews;

        private void Awake()
        {
            layerViews = new List<LayerView>();
        }
    }
}
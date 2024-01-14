using Composite.Core;
using System.Collections.Generic;
using UnityEngine;

namespace App.Features.Tower
{
	public class TowerView : AbstractView
	{
		public List<LayerView> tower;

        private void Awake()
        {
            tower = new List<LayerView>();
        }
    }
}
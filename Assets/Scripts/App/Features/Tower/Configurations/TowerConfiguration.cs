using UnityEngine;

namespace App.Features.Tower
{
	[CreateAssetMenu(menuName = "Configuration/Features/Tower/TowerConfiguration", fileName = "TowerConfiguration")]
	public class TowerConfiguration : AbstractConfiguration
	{
        public LayerConfiguration layerConfiguration;
        public LayerView layerViewPrefab;
	}
}
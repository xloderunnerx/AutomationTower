using UnityEngine;

namespace App.Features.Structures
{
	[CreateAssetMenu(menuName = "Configuration/Features/Structures/StructuresConfiguration", fileName = "StructuresConfiguration")]
	public class StructuresConfiguration : AbstractConfiguration
	{
		public LayerConfiguration layerConfiguration;
		public LayerView layerViewPrefab;
	}
}
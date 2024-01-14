using Assets.Scripts.App.Features.Structures.Views;
using System.Collections.Generic;
using UnityEngine;

namespace App.Features.Structures
{
	[CreateAssetMenu(menuName = "Configuration/Features/Structures/StructuresConfiguration", fileName = "StructuresConfiguration")]
	public class StructuresConfiguration : AbstractConfiguration
	{
		public LayerConfiguration layerConfiguration;
		public LayerView layerViewPrefab;

		public BoxView boxViewPrefab;
	}
}
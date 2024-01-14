using UnityEngine;

namespace App.Features.Floor
{
	[CreateAssetMenu(menuName = "Configuration/Features/Floor/FloorConfiguration", fileName = "FloorConfiguration")]
	public class FloorConfiguration : AbstractConfiguration
	{
		public Vector2Int size;
		public TileView tileViewPrefab;
	}
}
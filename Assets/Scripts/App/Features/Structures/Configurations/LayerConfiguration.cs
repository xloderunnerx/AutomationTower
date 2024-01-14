using UnityEngine;

namespace App.Features.Structures
{
    [CreateAssetMenu(menuName = "Configuration/Features/Structures/LayerConfiguration", fileName = "LayerConfiguration")]
    public class LayerConfiguration : ScriptableObject
    {
        public TileView tileViewPrefab;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace App.Features.Tower
{
    [CreateAssetMenu(menuName = "Configuration/Features/Tower/LayerConfiguration", fileName = "LayerConfiguration")]
    public class LayerConfiguration : ScriptableObject
    {
        public Vector2Int layerSize;
        public float betweenLayerSpacing;
        public TileView tileViewPrefab;
        public Color bordersColor;
    }
}
